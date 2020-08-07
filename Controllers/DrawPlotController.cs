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
using PagedList;

namespace IonicApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DrawPlotController : ControllerBase
    {
        private readonly IPeDrawPlotRepository _drawPlotRepository;
        private readonly IMapper _mapper;

        public DrawPlotController(IPeDrawPlotRepository peDrawPlotRepository, IMapper mapper)
        {
            _drawPlotRepository = peDrawPlotRepository ?? throw new ArgumentNullException(nameof(peDrawPlotRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// 获取手工组卷列表
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="currentUserId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DrawPlotsList(string authtoken,int createdUserId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                ret.retcode = 0;
                var DrawPlots = await _drawPlotRepository.GetPeDrawPlotsAsync(createdUserId);
                ret.info = _mapper.Map<IEnumerable<PeDrawPlotDto>>(DrawPlots);
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 获取题型
        /// </summary>
        /// <param name="drawplotId">手工组卷Id</param>
        /// <returns></returns>
        public async Task<ActionResult> TestPaperTopic(string authtoken, int drawplotId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var topicList = await _drawPlotRepository.GetTopicListAsync(drawplotId);
                ret.info = _mapper.Map<IEnumerable<PaperTopicDto>>(topicList);
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }


        public async Task<ActionResult> LabTopic(string authtoken, int labId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var topicList = await _drawPlotRepository.GetLabTopicListAsync(labId);
                ret.info = _mapper.Map<IEnumerable<DrawPlotTopicDto>>(topicList);
                ret.message = "成功获取题库对应的题型信息";
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }


        /// <summary>
        /// 获取题目列表
        /// </summary>
        /// <param name="authtoken">令牌</param>
        /// <param name="labId">策略id</param>
        /// <param name="topicList">题型id，查询多个时用","隔开</param>
        /// <param name="difficultyList">难度id，查询多个时用","隔开</param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public async Task<ActionResult> QuestionList(string authtoken, int labId, string topicList, string difficultyList, int page = 1, int count = 10)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var entity = await _drawPlotRepository.GetQuesListAsync(labId, topicList, difficultyList);
                IPagedList<PeQuestion> list = new PagedList<PeQuestion>(entity, page, count);
                var questionList = _mapper.Map<IEnumerable<QuestionDto>>(list);
                ret.retcode = 0;
                ret.pagecount = list.PageCount;
                ret.recordcount = list.TotalItemCount;
                ret.isfirst = list.IsFirstPage;
                ret.hasnext = list.HasNextPage;
                ret.info = questionList;
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 保存手工组卷
        /// </summary>
        /// <param name="authtoken">令牌</param>
        /// <param name="drawplotId">手工组卷id</param>
        /// <param name="quesList">题目Id 多个时用","隔开</param>
        /// <returns></returns>
        public async Task<ActionResult> SaveQuestion(string authtoken, int drawplotId, string quesList)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                string[] quesSaved = quesList.Split(',');
                try
                {
                    PeUserTestPaper entity = _drawPlotRepository.GetPaper(drawplotId);
                    //没有数据
                    if (entity == null)
                    {
                        PeUserTestPaper userTestPaper = new PeUserTestPaper();
                        userTestPaper.CreateTime = DateTime.Now;
                        userTestPaper.CreateUserId = AuthtokenUtility.GetId(authtoken);
                        userTestPaper.IsDel = false;
                        userTestPaper.DrawplotId = drawplotId;
                        userTestPaper.Title = "测试数据添加手工策略的试卷";
                        int paperId = _drawPlotRepository.AddUserTestPaper(userTestPaper);
                        List<PeTopic> listTopic = new List<PeTopic>();
                        foreach (string quesId in quesSaved)
                        {
                            if (!String.IsNullOrEmpty(quesId))
                            {
                                int TopicId = _drawPlotRepository.GetQuestion(int.Parse(quesId)).TopicId;
                                PeTopic itemtopic =await _drawPlotRepository.GetTopicAsync(TopicId);
                                if (!listTopic.Contains(itemtopic))
                                {
                                    listTopic.Add(itemtopic);
                                }
                            }
                        }
                        int topiclist = listTopic.Count;
                        int topicOrder = 0;
                        foreach (PeTopic topicitem in listTopic)
                        {
                            PeUserTestPaperTopic testpapertopic = new PeUserTestPaperTopic();
                            testpapertopic.Name = topicitem.Name;
                            testpapertopic.BasicTopicId = topicitem.BasicTopicId;
                            testpapertopic.TopicId = topicitem.Id;
                            testpapertopic.PaperId = paperId;
                            testpapertopic.Ord = topicOrder; topicOrder++;
                            testpapertopic.IsDel = false;
                            //数据库添加手工组卷的题型记录
                            int topicId = _drawPlotRepository.AddUserTestPaperTopic(testpapertopic);
                            for (int i = 0; i < quesSaved.Length; i++)
                            {
                                string quesId = quesSaved[i];
                                //题目所属题型
                                int TopicId =  _drawPlotRepository.GetQuestion(int.Parse(quesId)).TopicId;
                                PeTopic itemtopic =await _drawPlotRepository.GetTopicAsync(TopicId);
                                PeQuestion itemques = _drawPlotRepository.GetQuestion(int.Parse(quesId));
                                //题目列表中题型和数据库中题型相同时添加
                                if (itemtopic.Name.Trim().Equals(topicitem.Name.Trim().ToString()))
                                {
                                    PeUserTestPaperQuestions testpaperQues = new PeUserTestPaperQuestions();
                                    testpaperQues.PaperId = paperId;
                                    testpaperQues.QuestionId = int.Parse(quesId);
                                    testpaperQues.TopicId = topicId;
                                    testpaperQues.Rank = i;
                                    testpaperQues.IsDel = false;
                                    testpaperQues.Ord = i.ToString();
                                    //数据库添加手工组卷的题目记录
                                    _drawPlotRepository.AddUserTestPaperQues(testpaperQues);
                                }
                            }
                        }
                        ret.retcode = 0;
                        ret.info = paperId + "|" + quesList;
                        ret.message = "新增组卷题目";
                    }
                    //存在相关试卷。修改试卷内容
                    else
                    {
                        //题型
                        List<PeTopic> listTopic = new List<PeTopic>();
                        foreach (string quesId in quesSaved)
                        {
                            if (!String.IsNullOrEmpty(quesId))
                            {
                                //题目所属的题型
                                int TopicId =  _drawPlotRepository.GetQuestion(int.Parse(quesId)).TopicId;
                                PeTopic itemtopic = await _drawPlotRepository.GetTopicAsync(TopicId);
                                //题型是否存在
                                if (!listTopic.Contains(itemtopic))
                                {
                                    //不存在，添加到list集合
                                    listTopic.Add(itemtopic);
                                }
                            }
                        }
                        //根据题目列出所有的题型
                        int topiclist = listTopic.Count;
                        int topicOrder = 0;
                        foreach (PeTopic topicitem in listTopic)
                        {
                            int topicId = 0;
                            //根据题型和试卷id去查找试卷中是否有该题型
                            PeUserTestPaperTopic testpapertopicModel =await _drawPlotRepository.GetByTopicIdAsync(topicitem.Id, entity.Id);

                            topicOrder++;
                            if (testpapertopicModel == null)//需要新增一个题型
                            {
                                PeUserTestPaperTopic testpapertopic = new PeUserTestPaperTopic();
                                testpapertopic.Name = topicitem.Name;
                                testpapertopic.TopicId = topicitem.Id;
                                testpapertopic.PaperId = entity.Id;
                                testpapertopic.IsDel = false;
                                testpapertopic.Ord = topicOrder;
                                testpapertopic.BasicTopicId = topicitem.BasicTopicId;
                                //数据库添加手工组卷的题型记录
                                topicId = _drawPlotRepository.AddUserTestPaperTopic(testpapertopic);
                            }
                            //如果有这个题型就修改排序位置
                            else
                            {
                                topicId = testpapertopicModel.Id;
                                testpapertopicModel.Ord = topicOrder;
                                _drawPlotRepository.updateTopicOrdAsync(testpapertopicModel);
                            }

                            for (int i = 0; i < quesSaved.Length; i++)
                            {
                                string quesId = quesSaved[i];
                                if (!String.IsNullOrEmpty(quesId))
                                {
                                    continue;
                                }
                                PeUserTestPaperQuestions quesModel = await _drawPlotRepository.IsPaperContainsAsync(int.Parse(quesId), entity.Id);
                                //需要新增
                                if (quesModel == null)
                                {
                                    PeTopic itemtopic =  _drawPlotRepository.GetQuestion(int.Parse(quesId)).Topic;
                                    PeQuestion itemques =  _drawPlotRepository.GetQuestion(int.Parse(quesId));
                                    //题目列表中题型和数据库中题型相同时添加
                                    if (itemtopic.Name.Trim().Equals(topicitem.Name.Trim().ToString()))
                                    {
                                        PeUserTestPaperQuestions testpaperQues = new PeUserTestPaperQuestions();
                                        testpaperQues.PaperId = entity.Id;
                                        testpaperQues.QuestionId = int.Parse(quesId);
                                        testpaperQues.TopicId = topicId;
                                        testpaperQues.Rank = i;
                                        testpaperQues.IsDel = false;
                                        testpaperQues.Ord = i.ToString();
                                        //数据库添加手工组卷的题目记录
                                        _drawPlotRepository.AddUserTestPaperQues(testpaperQues);
                                    }
                                }
                                else
                                {
                                    //更新题目的排名
                                    _drawPlotRepository.udpateRankAsync(quesModel, i);

                                }
                            }
                        }
                        ret.retcode = 0;
                        ret.info = quesList;
                        ret.message = "二次编辑手工组卷题目";
                    }
                }
                catch (Exception e)
                {
                    ret.retcode = 12;
                    ret.info = e;
                    ret.message = "有bug";
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
        /// 根据题目ID获取题目信息
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public async Task<ActionResult> getQuestionById(string authtoken, int questionId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var question = await _drawPlotRepository.GetPeQuestion(questionId);
                ret.info = _mapper.Map<QuestionDto>(question);
                ret.retcode = 0;
                ret.message = "成功获取题目信息";
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 获取组卷内部的题目【PeUserTestPaperQuestion】
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="drawplotId">策略id</param>
        /// <returns></returns>
        public async Task<ActionResult> TextPaperQuestionList(string authtoken, int drawplotId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var textPaperQuestionsList = await _drawPlotRepository.GetTextPaperQuestionListAsync(drawplotId);
                ret.info = _mapper.Map<IEnumerable<PeUserTestPaperQuestionDto>>(textPaperQuestionsList);
                ret.retcode = 0;
                ret.message = "成功获取组卷题目";
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 根据题库id获取题库信息
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="labId">题库id</param>
        /// <returns></returns>
        public async Task<ActionResult> GetPeLab(string authtoken, int labId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var entity = await _drawPlotRepository.GetPeLabAsync(labId);
                ret.info = _mapper.Map<PeLabDto>(entity);
                ret.message = "成功获取题库名称等信息";
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 根据知识点id获取知识点内容
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="knowledgeId">知识点id</param>
        /// <returns></returns>
        public async Task<ActionResult> GetKnowledge(string authtoken, int knowledgeId)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var entity = await _drawPlotRepository.GetPeKnowledgeAsync(knowledgeId);//
                ret.info = entity.Name;//
                ret.message = "成功获取知识点内容";
            }
            else
            {
                ret.retcode = 13;
                ret.message = "令牌失效";
            }
            return Ok(ret);
        }

    }
}