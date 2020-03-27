using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    public class TestController : ControllerBase
    {
        private readonly ITestRepository _testRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        MapiData ret = new MapiData();

        public TestController(ITestRepository testRepository, ICourseRepository courseRepository, IMapper mapper)
        {
            _testRepository = testRepository ?? throw new ArgumentNullException(nameof(testRepository));
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// 获取课程下的所有作业
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.PeTest>>> GetHomeWorks(int courseId)
        {
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course)
            {
                ret.retcode = 0;
                ret.info = await _testRepository.GetTestsAsync(courseId);
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
        public async Task<ActionResult<Models.PeTest>> GetHomeWork(int id)
        {
            var homeWork = await _testRepository.GetTestAsync(id);
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
        public async Task<ActionResult<Models.PeTest>> AddHomeWork(int courseId, Models.PeTest peTest)
        {
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course || peTest == null)
            {
                ret.retcode = 11;
                throw new ArgumentException(nameof(peTest));
            }
            else
            {
                var entity = _mapper.Map<Models.PeTest>(course);
                _testRepository.AddTest(courseId, entity);
                _mapper.Map<TestAddDto>(entity);
                await _testRepository.SaveAsync();
                ret.retcode = 0;
            }
            return Ok(ret);
        }
        [HttpPatch]
        public async Task<ActionResult<Models.PeTest>> EditHomeWork(int id)
        {
            var homeWork = await _testRepository.GetTestAsync(id);
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
        /// 获取课程下的所有实验
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.PeTest>>> GetLabs(int courseId)
        {
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course)
            {
                ret.retcode = 0;
                ret.info = await _testRepository.GetLabsAsync(courseId);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        /// <summary>
        /// 获取课程下的所有练习
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.PeTest>>> GetExercises(int courseId)
        {
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course)
            {
                ret.retcode = 0;
                ret.info = await _testRepository.GetExercisesAsync(courseId);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
    }
}