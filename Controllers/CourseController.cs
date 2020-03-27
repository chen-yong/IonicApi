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


    }
}