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
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace IonicApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IUserRepository _userRepository;
        private readonly IPaperOutputTaskRepository _outputTaskRepository;
        private readonly IMapper _mapper;

        public CourseController(ICourseRepository courseRepository, IUserRepository userRepository, IPaperOutputTaskRepository paperOutRepository, IMapper mapper)
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _outputTaskRepository = paperOutRepository ?? throw new ArgumentNullException(nameof(paperOutRepository));
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
            MapiData ret = new MapiData();
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
            MapiData ret = new MapiData();
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
            MapiData ret = new MapiData();
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
        /// <param name="keyword">关键字</param>
        /// <param name="page">页码</param>
        /// <param name="count">每页数量</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeTest>>> HomeWorkList(int courseId, int type, string keyword, int page, int count)
        {
            MapiData ret = new MapiData();
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course)
            {
                var entity = await _courseRepository.GetTestsAsync(courseId, type, keyword);
                IPagedList<PeTest> list = new PagedList<PeTest>(entity, page, count);
                var test = _mapper.Map<IEnumerable<TestDto>>(list);
                ret.retcode = 0;
                ret.pagecount = list.PageCount;
                ret.recordcount = list.TotalItemCount;
                ret.isfirst = list.IsFirstPage;
                ret.hasnext = list.HasNextPage;
                ret.info = test;
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
            MapiData ret = new MapiData();
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
            MapiData ret = new MapiData();
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
            MapiData ret = new MapiData();
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
            MapiData ret = new MapiData();
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

        #region 成绩
        /// <summary>
        /// 获取课程学生成绩
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeCourseStudent>>> GradeList(int courseId)
        {
            MapiData ret = new MapiData();
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
        /// <summary>
        /// 未完成
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<StudentScoreInfoModel>>> ScoreInfo(int courseId, int type)
        {
            MapiData ret = new MapiData();
            StudentScoreInfoModel model = new StudentScoreInfoModel();
            model.Course = await _courseRepository.GetCourse(courseId);
            model.Tests = await _courseRepository.GetTestsAsync(courseId, type);
            var students = await _courseRepository.GradeListAsync(courseId);
            model.Students = new PagedList<PeCourseStudent>(students, 10, 1);
            if (model != null)
            {
                ret.retcode = 0;
                ret.info = model;
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        /// <summary>
        /// 作业，实验，考试成绩所属学生基本信息
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="keyword">关键词</param>
        /// <param name="page">页码</param>
        /// <param name="count">每页数量</param>
        /// <returns></returns>
        public async Task<ActionResult> StudentList(int courseId, string keyword, int page, int count)
        {
            MapiData ret = new MapiData();
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
            }
            return Ok(ret);
        }

        /// <summary>
        /// 获取单个学生汇总成绩（未完成）
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="id">学生Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeCourseStudent>>> StudentGrade(int courseId, int id)
        {
            MapiData ret = new MapiData();
            var grade = await _courseRepository.GradeExists(courseId);
            if (grade)
            {
                ret.retcode = 0;
                var entity = await _courseRepository.GradeAsync(courseId, id);
                ret.info = entity;//_mapper.Map<IEnumerable<CJHZDto>>(entity);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        #endregion

        #region 课程资源
        /// <summary>
        /// 获取课程资源
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="parentId">parentId</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeResource>>> ResourceList(int courseId, int parentId = 0)
        {
            MapiData ret = new MapiData();
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course)
            {
                ret.retcode = 0;
                var entity = await _courseRepository.GetResourcesAsync(courseId, parentId);
                ret.info = _mapper.Map<IEnumerable<ResourceDto>>(entity);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }
        /// <summary>
        /// 搜索课程资源
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="parentId">parentId</param>
        /// <param name="keyword">关键词</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeResource>>> SearchResource(int courseId, int parentId, string keyword)
        {
            MapiData ret = new MapiData();
            var course = await _courseRepository.CourseExistAsync(courseId);
            if (course)
            {
                ret.retcode = 0;
                var entity = await _courseRepository.GetResourcesAsync(courseId, parentId, keyword);
                ret.info = _mapper.Map<IEnumerable<ResourceDto>>(entity);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }

        /// <summary>
        /// 删除资源
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PeResource>> DeleteResource(int id)
        {
            MapiData ret = new MapiData();
            PeResource entity = await _courseRepository.GetResourceAsync(id);
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

        /// <summary>
        /// 文件资源重命名
        /// </summary>
        /// <param name="id">资源Id</param>
        /// <param name="name">名称</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PeResource>> Rename(int id, string name)
        {
            MapiData ret = new MapiData();
            PeResource entity = await _courseRepository.GetResourceAsync(id);
            if (entity != null && !string.IsNullOrEmpty(name))
            {
                //后缀名
                string[] array = entity.FileName.Split(".");
                string postfix = array[array.Length - 1];
                entity.FileName = FileUtils.FilterDangerCharacter(FileUtils.RemoveBlank(name)) + "." + postfix;
                await _userRepository.SaveAsync();
                ret.retcode = 0;
                ret.message = "重命名成功";
            }
            else
            {
                ret.retcode = 11;
                ret.message = "参数错误";
            }
            return Ok(ret);
        }
        /// <summary>
        /// 创建文件夹（未完成）
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public ActionResult CreateDirectory(int id, string Name, int courseId)
        {
            MapiData ret = new MapiData();
            PeResource entity = new PeResource();
            try
            {
                entity.ParentId = id;
                entity.FileName = FileUtils.FilterDangerCharacter(FileUtils.RemoveBlank(Name));
                entity.FileType = "DIR";
                entity.FileIcon = "dir";
                entity.IsDir = true;
                entity.CreateTime = DateTime.Now;
                entity.Password = "";
                entity.UserId = 1;
                entity.Size = 0;
                //entity.Url = VirtualPathUtility.Combine(VirtualRootPath, entity.FileName);
                //_userRepository
                entity.PeCourseResource.Add(new PeCourseResource { CourseId = courseId });
                _userRepository.SaveAsync();
                ret.retcode = 0;
            }
            catch
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }

        #endregion

        #region 试卷打印
        /// <summary>
        ///  打印任务展示列表
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PePaperOutputTask>>> PaperTaskList(int userId)
        {
            MapiData ret = new MapiData();
            var user = await _userRepository.UserExistsAsync(userId);
            if (user)
            {
                ret.retcode = 0;
                var entity = await _outputTaskRepository.GetPaperTasksAsync(userId);
                ret.info = _mapper.Map<IEnumerable<PaperOutputTaskDto>>(entity);
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }

        /// <summary>
        /// 重新启动打印任务（未完成）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<PePaperOutputTask>>> ResetPaperTask(int id)
        {
            MapiData ret = new MapiData();
            PePaperOutputTask entity = await _outputTaskRepository.GetPaperTaskAsync(id);
            if (entity != null)
            {
                entity.StartTime = DateTime.Now;
                entity.Message = "";
                entity.Result = "";
                entity.FinishTime = null;
                ret.retcode = 0;
            }
            else
            {
                ret.retcode = 11;
            }
            return Ok(ret);
        }

        /// <summary>
        /// 删除打印任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PePaperOutputTask>>> DeletePaperTask(int id)
        {
            MapiData ret = new MapiData();
            PePaperOutputTask entity = await _outputTaskRepository.GetPaperTaskAsync(id);
            if (entity != null)
            {
                _outputTaskRepository.DeletePaperTask(entity);
                await _outputTaskRepository.SaveAsync();
                ret.retcode = 0;
                ret.message = "删除成功";
            }
            else
            {
                ret.retcode = 11;
                ret.message = "删除失败";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 添加打印任务（未做）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<PePaperOutputTask>>> AddPaperTask(int id)
        {
            MapiData ret = new MapiData();
            PePaperOutputTask entity = await _outputTaskRepository.GetPaperTaskAsync(id);
            if (entity != null)
            { 

            }
            else
            {
                ret.retcode = 11;
                ret.message = "失败";
            }
            return Ok(ret);
        }
        /// <summary>
        /// 编辑打印任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<PePaperOutputTask>>> EditPaperTask(int id)
        {
            MapiData ret = new MapiData();
            PePaperOutputTask entity = await _outputTaskRepository.GetPaperTaskAsync(id);
            if (entity != null)
            {

            }
            else
            {
                ret.retcode = 11;
                ret.message = "失败";
            }
            return Ok(ret);
        }
        #endregion
    }
}