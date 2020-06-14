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

        /// <summary>
        /// 题目（待完善）
        /// </summary>
        /// <param name="authtoken">令牌</param>
        /// <param name="labId">策略id</param>
        /// <param name="topicList">题型id</param>
        /// <param name="difficultyList"></param>
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
    }
}