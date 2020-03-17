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
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    { 
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseController(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
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
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                ret.retcode = 0;
                var courses = await _courseRepository.GeCoursesAsync(authtoken);
                ret.info = _mapper.Map<IEnumerable<CourseDto>>(courses);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }

    }
}