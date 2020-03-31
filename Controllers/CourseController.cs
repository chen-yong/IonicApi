using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IonicApi.Common;
using IonicApi.Dtos;
using IonicApi.Models;
using IonicApi.Modes;
using IonicApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IonicApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseController : ControllerBase
    { 
        private readonly ICourseRepository _courseRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        MapiData ret = new MapiData();

        public CourseController(ICourseRepository courseRepository, IUserRepository userRepository, IMapper mapper)
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            //注册AutoMapper
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        #region 课程
        /// <summary>
        /// 根据登录人authtoken获取课程信息
        /// </summary>
        /// <param name="authtoken"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeCourse>>> GetCourses(string authtoken)
        {
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                ret.retcode = 0;
                var courses = await _courseRepository.GetCoursesAsync(authtoken);
                ret.info = _mapper.Map<IEnumerable<CourseDto>>(courses);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }

        /// <summary>
        /// 获取课程详细信息
        /// </summary>
        /// <param name="id">课程Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeCourse>>> GetCourse(int id)
        {
            var course = await _courseRepository.CourseExistAsync(id);
            if (course)
            {
                ret.retcode = 0;
                var courses = await _courseRepository.GetCourseAsync(id);
                ret.info = _mapper.Map<IEnumerable<CourseDto>>(courses);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        /// <summary>
        /// 创建课程
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="course">课程实体</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<CourseDto>> CreateCourse(int userId, CourseAddDto course)
        {
            if (!await _userRepository.UserExistsAsync(userId))
            {
                ret.retcode = 11;
            }
            else
            {
                var entity = _mapper.Map<PeCourse>(course);
                _courseRepository.AddCourse(userId, entity);
                _mapper.Map<CourseAddDto>(entity);
                await _courseRepository.SaveAsync();
                ret.retcode = 0;
            }
            return Ok(ret);
        }

        #endregion

        #region 作业实验练习
        /// <summary>
        /// 获取作业、实验、练习列表
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="type">类型：type=1考试 type=2练习 type=3作业 type=4实验</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeTest>>> HomeWorkList(int courseId,int type)
        {
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course)
            {
                ret.retcode = 0;
                ret.info = await _courseRepository.GetTestsAsync(courseId, type);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        /// <summary>
        /// 根据Id获取作业
        /// </summary>
        /// <param name="id">作业Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PeTest>> HomeWork(int id)
        {
            var homeWork = await _courseRepository.GetTestAsync(id);
            if (homeWork == null)
            {
                ret.retcode = 11;
            }
            ret.retcode = 0;
            ret.info = homeWork;
            return Ok(ret);
        }

        /// <summary>
        /// 添加作业
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="peTest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<PeTest>> AddHomeWork(int courseId, PeTest peTest)
        {
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course || peTest == null)
            {
                ret.retcode = 11;
                throw new ArgumentException(nameof(peTest));
            }
            else
            {
                var entity = _mapper.Map<PeTest>(course);
                _courseRepository.AddTest(courseId, entity);
                _mapper.Map<TestAddDto>(entity);
                await _courseRepository.SaveAsync();
                ret.retcode = 0;
            }
            return Ok(ret);
        }
        [HttpPatch]
        public async Task<ActionResult<PeTest>> EditHomeWork(int id)
        {
            var homeWork = await _courseRepository.GetTestAsync(id);
            if (homeWork == null)
            {
                ret.retcode = 11;
            }
            else
            {

            }
            return Ok(ret);
        }
        /// <summary>
        /// 删除作业，实验，练习
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PeTest>> DeleteWork(int id)
        {
            PeTest entity = await _courseRepository.GetTestAsync(id);
            if (entity != null)
            {
                entity.IsDel = true;
                await _userRepository.SaveAsync();
                ret.retcode = 0;
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
      
        #endregion
        /// <summary>
        /// 获取课程学生成绩
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeCourseStudent>>> GradeList(int courseId)
        {
            var grade = await _courseRepository.GradeExists(courseId);
            if (grade)
            {
                ret.retcode = 0;
                ret.info = await _courseRepository.GradeListAsync(courseId);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        public async Task<ActionResult<IEnumerable<StudentScoreInfoModel>>> ScoreInfo(int courseId,int type)
        {
            StudentScoreInfoModel model = new StudentScoreInfoModel();
            model.Course = await _courseRepository.GetCourse(courseId);
            model.Tests = await _courseRepository.GetTestsAsync(courseId, type);
            //var students = await _courseRepository.GradeListAsync(courseId);
            //var students = await _courseRepository.GradeListAsync(courseId) as IQueryable<PeCourseStudent>;
            //model.Students = await PagedList<PeCourseStudent>.CreateAsync(students, 10, 1);
            if (model != null)
            {
                ret.retcode = 0;
                ret.info = model;
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret.info);
        }
    }
}