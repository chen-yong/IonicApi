using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IonicApi.Models;
using IonicApi.Repositories;
using AutoMapper;
using IonicApi.Modes;
using IonicApi.Dtos;
using IonicApi.Common;
using Microsoft.AspNetCore.JsonPatch;
using PagedList;

namespace IonicApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper, ICourseRepository courseRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            //注册AutoMapper
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// 根据课程ID获取所属学生基本信息
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <param name="courseId">课程Id</param>
        /// <param name="keyword">关键词</param>
        /// <param name="page">页码</param>
        /// <param name="count">每页数量</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> StudentList(string authtoken, int courseId, string keyword, int page = 1, int count = 10)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var course = await _courseRepository.CourseExistAsync(courseId);
                if (course)
                {
                    var entity = await _userRepository.GetUsersAsync(courseId, keyword);
                    IPagedList<PeUser> list = new PagedList<PeUser>(entity, page, count);
                    var student = _mapper.Map<IEnumerable<StudentDto>>(list);
                    ret.retcode = 0;
                    ret.pagecount = list.PageCount;
                    ret.recordcount = list.TotalItemCount;
                    ret.isfirst = list.IsFirstPage;
                    ret.hasnext = list.HasNextPage;
                    ret.info = student;
                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "参数错误";
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 根据id获取学生信息
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <param name="id">学生Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetStudent(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken)) //用户登录的时候会生成authtoken令牌
            {
                var user = await _userRepository.UserExistsAsync(id);  //该id的学生是否存在
                if (user)
                {
                    var entity = await _userRepository.GetUserAsync(id);
                    ret.retcode = 0;
                    ret.info = _mapper.Map<StudentDto>(entity);
                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "参数错误";
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 在课程中添加学生
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <param name="courseId">课程Id</param>
        /// <param name="addUser">用户信息</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddCourseStudent(string authtoken, int courseId, [FromBody] UserAddDto addUser)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var entity = _mapper.Map<PeUser>(addUser);
                PeUser user = _userRepository.GetUser(entity.UserName); //数据库里username是长长一串，唯一表示
                //新账号
                if (user == null)
                {
                    entity.Password = StringUtils.md5HashString("123456").ToUpper();
                    entity.UserIdentity01 = "1";
                    entity.UserIdentity03 = "1";
                    if (string.IsNullOrEmpty(entity.Sex)) entity.Sex = "男";
                    entity.PeCourseStudent.Add(new PeCourseStudent
                    {
                        CourseId = courseId
                    });
                    _userRepository.AddUser(entity);
                    ret.retcode = 0;
                    ret.message = "新增新学生成功";
                }
                else
                {
                    //老师账号
                    if (user.UserIdentity03 == "2") //教师帐号
                    {
                        ret.retcode = 11;
                        ret.message = "用户已经存在";
                    }
                    //学生已经存在，添加到PeCourseStudent表中与课程关联
                    else
                    {
                        user.PeCourseStudent.Add(new PeCourseStudent
                        {
                            CourseId = courseId //这里为什么不需要关联该学生的id
                        });
                        ret.retcode = 0;
                        ret.message = "学生关联到课程中成功";
                    }
                }
                await _userRepository.SaveAsync();
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> RetsetPwd(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeUser entity = await _userRepository.GetUserAsync(id);
                if (entity != null)
                {
                    entity.Password = StringUtils.md5HashString("123456").ToUpper();
                    ret.retcode = 0;
                    ret.message = "密码重置成功";
                    await _userRepository.SaveAsync();
                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "参数错误";
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 删除用户（逻辑）
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeleteUser(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeUser entity = await _userRepository.GetUserAsync(id);
                if (entity != null)
                {
                    entity.UserIdentity01 = "0";
                    await _userRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "参数错误";
                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "删除成功";
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 更新学生（patch局部更新）
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <param name="id"></param>
        /// <param name="patchDocument">更新操作</param>
        /// 
        /// patchDocument中UserEditDto用户名UserName 和 密码 Password必须要写（postman中首字母小写）
        /// <returns></returns>
        [HttpPatch]
        public async Task<ActionResult> EditUser(string authtoken, int id, [FromBody] JsonPatchDocument<UserEditDto> patchDocument)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeUser entity = await _userRepository.GetUserAsync(id);
                if (entity != null)
                {
                    try
                    {
                        var dtoToPatch = _mapper.Map<UserEditDto>(entity);
                        // 需要处理验证错误
                        patchDocument.ApplyTo(dtoToPatch, ModelState);

                        if (!TryValidateModel(dtoToPatch))
                        {
                            return ValidationProblem(ModelState);
                        }

                        _mapper.Map(dtoToPatch, entity);
                        _userRepository.UpdateUser(entity);
                        ret.retcode = 0;
                        ret.message = "修改成功";
                        await _userRepository.SaveAsync();
                    }
                    catch (Exception e)
                    {
                        ret.retcode = 11;
                        ret.info = e;
                    }

                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "参数错误";
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        [HttpPatch]
        public async Task<ActionResult> EditAdmin(string authtoken, int id, [FromBody] JsonPatchDocument<AdminEditDto> patchDocument)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeUser entity = await _userRepository.GetUserAsync(id);
                if (entity != null)
                {
                    try
                    {
                        var dtoToPatch = _mapper.Map<AdminEditDto>(entity);
                        // 需要处理验证错误
                        patchDocument.ApplyTo(dtoToPatch, ModelState);

                        if (!TryValidateModel(dtoToPatch))
                        {
                            return ValidationProblem(ModelState);
                        }

                        _mapper.Map(dtoToPatch, entity);
                        _userRepository.UpdateUser(entity);
                        ret.retcode = 0;
                        ret.message = "用户修改成功";
                        await _userRepository.SaveAsync();
                    }
                    catch (Exception e)
                    {
                        ret.retcode = 11;
                        ret.info = e;
                    }

                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "参数错误";
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

    }


}
