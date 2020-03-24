using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IonicApi.Models;
using AutoMapper;
using IonicApi.Repositories;
using IonicApi.Modes;
using IonicApi.Dtos;

namespace IonicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITestRepository _testRepository;
        private readonly ICourseRepository _courseRepository;


        public TestController(IMapper mapper, ITestRepository testRepository, ICourseRepository courseRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _testRepository = testRepository ?? throw new ArgumentNullException(nameof(testRepository));
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
        }

        /// <summary>
        /// 获取课程下的所有作业
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<PeTest>>> GetHomeWorks(int courseId)
        {
            MapiData ret = new MapiData();
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
        [HttpGet("{id}")]
        public async Task<ActionResult<PeTest>> GetHomeWork(int id)
        {
            MapiData ret = new MapiData();
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
        public async Task<ActionResult<PeTest>> AddHomeWork(int courseId,PeTest peTest)
        {
            MapiData ret = new MapiData();
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course|| peTest == null)
            {
                ret.retcode = 11;
                throw new ArgumentException(nameof(peTest));
            }
            else
            {
                var entity = _mapper.Map<PeTest>(course);
                _testRepository.AddTest(courseId, entity);
                _mapper.Map<TestAddDto>(entity);
                await _testRepository.SaveAsync();
                ret.retcode = 0;
            }
            return Ok(ret);
        }
      
    }
}
