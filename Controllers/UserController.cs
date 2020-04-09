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

namespace IonicApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper,ICourseRepository courseRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _courseRepository= courseRepository?? throw new ArgumentNullException(nameof(courseRepository));
            //注册AutoMapper
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// 根据课程ID获取学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PeUser>> GetStudents(int courseId)
        {
            MapiData ret = new MapiData();
            if (courseId > 0)
            {
                var studets = await _userRepository.GetUsersAsync(courseId);
                if (studets != null)
                {
                    ret.retcode = 0;
                    ret.info = _mapper.Map<IEnumerable<UserDto>>(studets);
                }
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        /// <summary>
        /// 在课程中添加学生
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<PeUser>> AddCourseStudent(int courseId, PeUser entity)
        {
            MapiData ret = new MapiData();
            if (!await _userRepository.UserExists(entity.UserName))
            {
                ret.retcode = 11;
                ret.message = "此学生已存在";
            }
            if (!await _userRepository.UserExists(entity.UserName))
            {
                entity.Password = StringUtils.md5HashString("123456");
                entity.UserIdentity01 = "1";
                entity.UserIdentity03 = "1";
                entity.PeCourseStudent.Add(new PeCourseStudent
                {
                    CourseId = courseId
                });
                _userRepository.AddUser(entity);
                await _userRepository.SaveAsync();
                ret.retcode = 0;
            }
            else
            {
                ret.retcode = 99;
            }
            return Ok(ret);
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PeUser>> RetsetPwd(int id)
        {
            MapiData ret = new MapiData();
            PeUser entity= await _userRepository.GetUserAsync(id);
            if (entity != null)
            {
                entity.Password = StringUtils.md5HashString("123456");
                ret.retcode = 0;
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }

        /// <summary>
        /// 删除用户（逻辑）
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PeUser>> DeleteUser(int id)
        {
            MapiData ret = new MapiData();
            PeUser entity = await _userRepository.GetUserAsync(id);
            if (entity != null)
            {
                entity.UserIdentity01 = "0";
                await _userRepository.SaveAsync();
                ret.retcode = 0;
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        [HttpPatch]
        public async Task<ActionResult<PeUser>>EditUser(int id,PeUser peUser)
        {
            MapiData ret = new MapiData();
            PeUser entity = await _userRepository.GetUserAsync(id);
            if (entity != null)
            {
                ret.retcode = 0;
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }

        /// <summary>
        /// 查询学生
        /// </summary>
        /// <param name="courseId">课程ID</param>
        /// <param name="keyword">关键词</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> SearchUser(int courseId, string keyword)
        {
            MapiData ret = new MapiData();
            if (!await _courseRepository.CourseExistAsync(courseId))
            {
                ret.retcode = 11;
            }
            else
            {
                ret.retcode = 0;
                var users = await _userRepository.GetUsersAsync(courseId, keyword);
                ret.info= _mapper.Map<IEnumerable<UserDto>>(users);
            }
            return Ok(ret);
        }

    }
}
