using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IonicApi.Common;
using IonicApi.Dtos;
using IonicApi.Modes;
using IonicApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}