﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ICSharpCode.SharpZipLib.Zip;
using IonicApi.Common;
using IonicApi.Common.Judge;
using IonicApi.Dtos;
using IonicApi.Models;
using IonicApi.Modes;
using IonicApi.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.JsonPatch;
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
        //通过网站相对路径获取物理实际路径
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CourseController(ICourseRepository courseRepository, IUserRepository userRepository, IPaperOutputTaskRepository paperOutRepository, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _outputTaskRepository = paperOutRepository ?? throw new ArgumentNullException(nameof(paperOutRepository));
            //注册AutoMapper
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            //文件路径
            _webHostEnvironment = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
        }
        #region 课程
        /// <summary>
        /// 根据登录人authtoken获取课程信息
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetCoursesList(string authtoken)
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
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 获取课程详细信息
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <param name="id">课程Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetCourse(string authtoken,int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
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
                    ret.message = "参数错误";
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 根据学生用户id和登录令牌获取学生参加的所有课程
        /// </summary>
        /// <param name="authtoken">登录令牌</param>
        /// <param name="userId">学生的用户ID</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetCourseByStudent(string authtoken, int userId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var user = await _userRepository.UserExistsAsync(userId);  //该id的学生是否存在
                //var course = await _courseRepository.CourseExistAsync(id);
                if (user)
                {
                    var courses = await _courseRepository.GetCourseByStudentAsync(userId);
                    ret.info = _mapper.Map<IEnumerable<CourseDto>>(courses);
                    ret.retcode = 0;
                    ret.message = "成功获取学生参与的所有课程信息";
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
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }


        /// <summary>
        /// 创建课程(未测试)
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="course">课程实体</param>
        /// <returns></returns>
        //[HttpPost]
        //public async Task<ActionResult> CreateCourse(int userId, CourseAddDto course)
        //{
        //    MapiData ret = new MapiData();
        //    if (!await _userRepository.UserExistsAsync(userId))
        //    {
        //        ret.retcode = 11;
        //    }
        //    else
        //    {
        //        var entity = _mapper.Map<PeCourse>(course);
        //        _courseRepository.AddCourse(userId, entity);
        //        _mapper.Map<CourseAddDto>(entity);
        //        await _courseRepository.SaveAsync();
        //        ret.retcode = 0;
        //    }
        //    return Ok(ret);
        //}

        #endregion

        #region 抽题策略
        /// <summary>
        /// 抽题策略
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <returns></returns>
        public async Task<ActionResult> DrawPlotList(string authtoken)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                ret.retcode = 0;
                ret.authtoken = authtoken;
                var entity = await _courseRepository.GetDrawPlotsAsync(AuthtokenUtility.GetId(authtoken));
                ret.info = _mapper.Map<IEnumerable<DrawPlotOptions>>(entity);
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 根据策略id获取具体的策略信息
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id">策略id</param>
        /// <returns></returns>
        public async Task<ActionResult> GetDrawPlotById(string authtoken,int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                ret.retcode = 0;
                var entity = await _courseRepository.GetDrawPlotByIdAsync(id);
                ret.info = _mapper.Map<DrawPlotOptions>(entity);
                ret.message = "根据策略id成功获取选题策略";
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
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
        public async Task<ActionResult> HomeWorkList(string authtoken,int courseId, int type, string keyword, int page, int count)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
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
        /// 根据Id获取作业
        /// </summary>
        /// <param name="id">作业Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> HomeWork(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var homeWork = await _courseRepository.GetTestAsync(id);
                if (homeWork == null)
                {
                    ret.retcode = 11;
                    ret.message = "参数错误";
                }
                ret.retcode = 0;
                ret.info = _mapper.Map<TestDto>(homeWork);
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 添加作业、实验、练习
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="type">类型：type=1考试 type=2练习 type=3作业 type=4实验</param>
        /// <param name="peTest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddHomeWork(string authtoken, int courseId, int type, TestAddDto test)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var course = await _courseRepository.CourseExistAsync(courseId);
                if (!course)
                {
                    ret.retcode = 11;
                    throw new ArgumentException(nameof(test));
                }
                else
                {
                    var entity = _mapper.Map<PeTest>(test);
                    //课程Id
                    entity.CourseId = courseId;
                    entity.Mode = type;
                    //创建者Id
                    entity.CreateUserId = AuthtokenUtility.GetId(authtoken);
                    entity.CreateTime = DateTime.Now;
                    entity.IsOpen = true;
                    if (entity.DelayEndTime.HasValue)
                    {
                        entity.DelayEndTime = entity.EndTime.Value.AddDays(1).AddMinutes(-1);
                        entity.DelayPercentOfScore = entity.DelayPercentOfScore ?? 100;
                    }
                    if (entity.TimeLimit > 0)
                    {
                        entity.AutoSubmitOnTimeLimit = true;
                    }
                    entity.Nid = GUIDUtility.GenerateCharID();
                    _courseRepository.AddTest(entity);
                    await _courseRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "创建成功";
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        ///// <summary>
        ///// 编辑作业
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpPatch]
        //public async Task<ActionResult> EditHomeWork(string authtoken, int id, JsonPatchDocument<TestEditDto> patchDocument)
        //{
        //    MapiData ret = new MapiData();
        //    if (AuthtokenUtility.ValidToken(authtoken))
        //    {
        //        PeTest entity = await _courseRepository.GetTestAsync(id);
        //        if (entity != null)
        //        {
        //            try
        //            {
        //                var dtoToPatch = _mapper.Map<TestEditDto>(entity);
        //                // 需要处理验证错误
        //                patchDocument.ApplyTo(dtoToPatch, ModelState);

        //                if (!TryValidateModel(dtoToPatch))
        //                {
        //                    return ValidationProblem(ModelState);
        //                }

        //                _mapper.Map(dtoToPatch, entity);
        //                _courseRepository.UpdateTest(entity);
        //                ret.retcode = 0;
        //                ret.message = "修改成功";
        //                await _courseRepository.SaveAsync();
        //            }
        //            catch (Exception e)
        //            {
        //                ret.retcode = 11;
        //                ret.info = e;
        //            }
        //        }
        //        else
        //        {
        //            ret.retcode = 11;
        //            ret.message = "参数错误";
        //        }
        //    }
        //    else
        //    {
        //        ret.retcode = 13;
        //        ret.message = ret.debug = "登录令牌失效";
        //    }
        //    return Ok(ret);
        //}

        /// <summary>
        /// 编辑作业、实验、练习
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id">作业、实验、练习的id</param>
        /// <param name="editHomework">需要修改的传过来的内容</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> EditHomeWork(string authtoken, int id, [FromBody] TestEditDto editHomework)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeTest entity = await _courseRepository.GetTestAsync(id);
                if (entity != null)
                {
                    try
                    {
                        if (editHomework.Name != null)
                        {
                            entity.Name = editHomework.Name;
                        }
                        if (editHomework.StartTime != null)
                        {
                            entity.StartTime = editHomework.StartTime;
                        }
                        if (editHomework.EndTime != null)
                        {
                            entity.EndTime = editHomework.EndTime;
                        }
                        if (editHomework.DelayEndTime != null)
                        {
                            entity.DelayEndTime = editHomework.DelayEndTime;
                            entity.DelayPercentOfScore = editHomework.DelayPercentOfScore;
                        }
                        if (editHomework.Memo != null)
                        {
                            entity.Memo = editHomework.Memo;
                        }
                        if (editHomework.DrawPlotId != null)
                        {
                            entity.DrawPlotId = editHomework.DrawPlotId;
                        }
                        if (editHomework.SetScore != null)
                        {
                            entity.SetScore = editHomework.SetScore;
                        }
                        if (editHomework.ScoreAppear != null)
                        {
                            entity.ScoreAppear = editHomework.ScoreAppear;
                        }
                        if (editHomework.EnableClientJudge != null)
                        {
                            entity.EnableClientJudge = editHomework.EnableClientJudge;
                        }
                        if (editHomework.KeyVisible != null)
                        {
                            entity.KeyVisible = editHomework.KeyVisible;
                        }
                        entity.ViewOneWithAnswerKey = editHomework.ViewOneWithAnswerKey;       
                        if (editHomework.ForbiddenCopy != null)
                        {
                            entity.ForbiddenCopy = editHomework.ForbiddenCopy;
                        }
                        if (editHomework.ForbiddenMouseRightMenu != null)
                        {
                            entity.ForbiddenMouseRightMenu = editHomework.ForbiddenMouseRightMenu;
                        }
                        ret.retcode = 0;
                        ret.message = "作业、练习、实验修改成功";
                        await _courseRepository.SaveAsync();
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

        /// <summary>
        /// 删除作业，实验，练习
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeleteWork(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeTest entity = await _courseRepository.GetTestAsync(id);
                if (entity != null)
                {
                    entity.IsDel = true;
                    await _userRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "删除成功";
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

        #endregion

        #region 阅卷
        /// <summary>
        /// 作业，实验阅卷列表
        /// </summary>
        /// <param name="testId">作业，实验Id</param>
        /// <returns></returns>
        public async Task<ActionResult> JudgeList(string authtoken, int testId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var userTest = await _courseRepository.UserTestExists(testId);
                if (userTest)
                {
                    var entity = await _courseRepository.GetUserTestListAsync(testId);
                    ret.info = _mapper.Map<IEnumerable<UserTestDto>>(entity);
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
        /// 阅卷（有bug）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActionResult> JadgeTest(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                JudgeOneModel model = new JudgeOneModel();
                try
                {
                    PeUserTest ut = await _courseRepository.GetUserTestAsync(id);
                    List<Task<JudgeResult>> tasks = new List<Task<JudgeResult>>();
                    foreach (var item in ut.PeUserTestQuestion)
                    {
                        var proxy = JudgerUtility.UTQProxy(item, ut);
                        IJudger judger = JudgerUtility.CreateJudgerByReflection(item.Question.Topic.BasicTopic.JudgeClassName);
                        if (judger is IJudgerAsync)
                        {
                            tasks.Add(Task.Run<JudgeResult>(async () =>
                            {
                                JudgeResult r = await ((IJudgerAsync)judger).JudgeAsync(proxy);
                                r.TopicId = proxy.Question.TopicId;
                                r.TopicName = proxy.Question.Topic.Name;
                                r.BundleId = proxy.Question.BundleRank;
                                r.Ord = proxy.Question.Ord;
                                r.QuestionId = proxy.QuestionId;
                                double s = r.FullScore > 0 ? Math.Round(proxy.Question.Score * (r.GotScore / r.FullScore), 2) : 0;
                                item.Score = s;
                                if (item.BestScore < s)
                                {
                                    item.BestScore = s;
                                }
                                model.QuestionJudgeResultSet.Add(r);
                                return r;
                            }));
                        }
                        else
                        {
                            JudgeResult r = judger.Judge(proxy);
                            r.TopicId = proxy.Question.TopicId;
                            r.TopicName = proxy.Question.Topic.Name;
                            r.BundleId = proxy.Question.BundleRank;
                            r.Ord = proxy.Question.Ord;
                            r.QuestionId = proxy.QuestionId;
                            double s = r.FullScore > 0 ? Math.Round(proxy.Question.Score * (r.GotScore / r.FullScore), 2) : 0;
                            item.Score = s;
                            if (item.BestScore < s)
                            {
                                item.BestScore = s;
                            }
                            model.QuestionJudgeResultSet.Add(r);
                        }
                    }
                    await Task.WhenAll<JudgeResult>(tasks);
                    ut.Score = Math.Round(ut.PeUserTestQuestion.Sum(e => (e.Score ?? 0)), 2);
                    ut.ScoreAlter = ut.Test.SetScore.HasValue ? Math.Round((ut.Score * ut.Test.SetScore / ut.TotalScore) ?? 0, 2) : ut.Score;
                    if (ut.Test.DelayEndTime.HasValue && ut.IsSubmitDelay.HasValue && ut.IsSubmitDelay.Value)
                    {
                        ut.ScoreAlter = ut.ScoreAlter * (ut.Test.DelayPercentOfScore ?? 100) / 100;
                    }
                    ut.Status = true;
                    ut.Property08 = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
                    ut.JudgeReport = model.JudgeReport;
                    model.Score = ut.ScoreAlter ?? 0;
                    await _courseRepository.SaveAsync();
                    ret.info = model;
                    ret.message = "阅卷成功";
                }
                catch (Exception ex)
                {
                    ret.retcode = 12;
                    ret.message = "阅卷失败";
                    ret.debug = ex.ToString();
                }
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        #endregion

        #region 成绩
        /// <summary>
        /// 单个学生作业，实验，考试成绩
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="type">类型</param>
        /// <param name="userId">学生Id</param>
        /// <returns></returns>
        public async Task<ActionResult> ScoreInfo(string authtoken, int courseId, int type, int userId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken)) 
            {
                var tests = await _courseRepository.GetTestsAsync(courseId, type);
                if (tests != null)
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();

                    string str = "";
                    foreach (var test in tests)
                    {
                        str = await _courseRepository.GetTestScoreAsync(test.Id, userId);
                        dic.Add(test.Name, str);
                    }
                    ret.retcode = 0;
                    ret.info = dic;
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
        /// 获取单个学生汇总成绩
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="id">学生Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> StudentGrade(string authtoken, int courseId, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var grade = await _courseRepository.GradeExists(courseId);
                if (grade)
                {
                    ret.retcode = 0;
                    var entity = await _courseRepository.GradeAsync(courseId, id);
                    ret.info = _mapper.Map<IEnumerable<CJHZDto>>(entity);
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
        #endregion

        #region 课程资源 PeResource
        /// <summary>
        /// 搜索课程资源
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="parentId">parentId</param>
        /// <param name="keyword">关键词</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> SearchResource(string authtoken, int courseId, int parentId, string keyword)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
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
        /// 删除资源
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeleteResource(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
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
        /// 文件资源重命名
        /// </summary>
        /// <param name="id">资源Id</param>
        /// <param name="name">名称</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Rename(string authtoken, int id, string name)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
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
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }
        /// <summary>
        /// 创建文件夹（未完成）
        /// </summary>
        /// <param name="id">父子标志默认0</param>
        /// <param name="authtoken">登录令牌</param>
        /// <param name="Name">文件夹名称</param>
        /// <returns></returns>
        public ActionResult CreateDirectory(int id, string authtoken, string Name, int courseId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
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
                    entity.UserId = AuthtokenUtility.GetId(authtoken);
                    entity.Size = 0;
                    //entity.Url = VirtualPathUtility.Combine(VirtualRootPath, entity.FileName);
                    entity.PeCourseResource.Add(new PeCourseResource { CourseId = courseId });
                    _userRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "文件夹创建成功";
                }
                catch
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
        /// 未做
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> UploadFile()
        {
            MapiData ret = new MapiData();
            List<PeResource> uploadFiles = new List<PeResource>();

            return Ok(ret);
        }

        #endregion

        #region 试卷打印 PePaperOutputTask
        /// <summary>
        ///  打印任务展示列表
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="keyword">关键词</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> PaperTaskList(int courseId, string authtoken, string keyword)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var userId = AuthtokenUtility.GetId(authtoken);
                var user = await _userRepository.UserExistsAsync(userId);
                if (user)
                {
                    ret.retcode = 0;
                    var entity = await _outputTaskRepository.GetPaperTasksAsync(courseId, userId, keyword);
                    ret.info = _mapper.Map<IEnumerable<PaperOutputTaskDto>>(entity);
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
        /// 获取单个打印任务的信息
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> PaperTask(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                ret.retcode = 0;
                var entity = await _outputTaskRepository.GetPaperTaskAsync(id);
                ret.info = _mapper.Map<PaperOutputTaskDto>(entity);
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }
        /// <summary>
        /// 试卷打印任务下的选择考试选项
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        public async Task<ActionResult> ChooseTest(string authtoken, int courseId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var course = await _courseRepository.CourseExistAsync(courseId);
                if (course)
                {
                    var choose = await _courseRepository.ChooseTest(courseId);
                    ret.info = _mapper.Map<IEnumerable<ChooseTestDto>>(choose);
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
        /// 添加打印任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddPaperTask(int courseId, string authtoken, int testId, PePaperOutputTaskAddDto pePaper)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var course = await _courseRepository.CourseExistAsync(courseId);
                PeTest test = await _courseRepository.GetTestAsync(testId);
                if (course && test != null)
                {
                    var entity = _mapper.Map<PePaperOutputTask>(pePaper);
                    entity.TestId = testId;
                    entity.Name = test.Name + "试卷打印任务";
                    entity.Option1 = test.Name;
                    entity.CreateUser = AuthtokenUtility.GetId(authtoken);
                    entity.CreateUserName = _userRepository.GetRealName(AuthtokenUtility.GetId(authtoken));
                    entity.CreateTime = DateTime.Now;
                    entity.BeCreatePdfFile = false;
                    entity.CreateTempDir = "";
                    entity.Range = "ALL";
                    entity.StartTime = DateTime.Now;
                    entity.TotalCount = test.PeUserTest.Count;
                    _outputTaskRepository.AddPaperTask(entity);
                    await _outputTaskRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "添加成功";
                    Action action = async () =>
                    {
                        try
                        {
                            string zipFileName = "";
                            entity.Result = "成功";
                            entity.FileName = Path.GetFileName(zipFileName);
                            entity.FilePath = zipFileName;
                            entity.FileSize = FileUtils.DisplaySize(FileUtils.GetSize(zipFileName));
                            entity.FinishCount = entity.TotalCount;
                        }
                        catch (Exception ex)
                        {
                            entity.Result = "失败";
                            entity.Message = ex.Message;
                        }
                        finally
                        {
                            entity.FinishTime = DateTime.Now;
                        }
                        await _outputTaskRepository.SaveAsync();
                    };
                    await Task.Factory.StartNew(action);
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
        /// 重新启动打印任务（未完成）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActionResult> ResetPaperTask(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PePaperOutputTask entity = await _outputTaskRepository.GetPaperTaskAsync(id);
                if (entity != null)
                {
                    entity.StartTime = DateTime.Now;
                    entity.Message = "";
                    entity.Result = "";
                    entity.FinishTime = null;
                    ret.retcode = 0;
                    await _outputTaskRepository.SaveAsync();
                    Action action = async () =>
                    {
                        try
                        {
                            //未做 zipFileName
                            string zipFileName = "";
                            entity.Result = "成功";
                            entity.FileName = Path.GetFileName(zipFileName);
                            entity.FilePath = zipFileName;
                            entity.FileSize = FileUtils.DisplaySize(FileUtils.GetSize(zipFileName));
                            entity.FinishCount = entity.TotalCount;
                        }
                        catch (Exception ex)
                        {
                            entity.Result = "失败";
                            entity.Message = ex.Message;
                        }
                        finally
                        {
                            entity.FinishTime = DateTime.Now;
                        }
                        await _outputTaskRepository.SaveAsync();
                    };
                    await Task.Factory.StartNew(action);
                    ret.retcode = 0;
                    ret.message = "重启成功";
                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "重启失败";
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
        /// 删除打印任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeletePaperTask(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
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
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }
        #endregion

        #region zipFileName
        //public string zipFileName(PePaperOutputTask task)
        //{
        //    string relativePath = "";
        //    string absolutePath = "";
        //    if (!Directory.Exists(absolutePath)) Directory.CreateDirectory(absolutePath);
        //    string zipFileName = Path.Combine(absolutePath, GUIDUtility.GenerateCharID() + ".zip");
        //    IEnumerable<PeUserTest> todolist = task.Test.PeUserTest;
        //    using (ZipFile zip = new ZipFile())
        //    {
        //        foreach (var item in todolist)
        //        {
        //            TestOneModel model = new TestOneModel();
        //            string content;
        //            model.UserTest = item;
        //            model.Test = item.Test;
        //            model.PrintTitle = task.Option1;
        //            model.PrintSubTitle = task.Option2;
        //            if (!model.UserTest.PeUserTestQuestion.Any())
        //            {
        //                model.TopicSet = new List<PeTopic>();
        //            }
        //            else
        //            {
        //                model.TopicSet = item.PeUserTestQuestion.Select(e => e.PeTopic).Distinct().OrderBy(e => e.Ord);
        //            }

        //            foreach (var topic in model.TopicSet)
        //            {
        //                topic.SelectedQuestionSet = item.PeUserTestQuestion.Where(e => e.TopicId == topic.Id);
        //            }
        //            PaperOneView paper = new PaperOneView();
        //            content = paper.Render(model);
        //            foreach (var file in paper.Files)
        //            {
        //                ZipEntry _entry = zip.AddFile(file.Value, "files");
        //                _entry.FileName = "files/" + file.Key;
        //            }
        //            ZipEntry entry = zip.AddEntry(item.XH + ".pdf", xhtml2pdf.Converter.FromHtmlText(content));
        //        }
        //        zip.Save(zipFileName);
        //    }

        //        return zipFileName;
        //}
        #endregion

    }
}