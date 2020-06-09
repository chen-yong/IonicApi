using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IonicApi.Common;
using IonicApi.Config;
using IonicApi.Dtos;
using IonicApi.Models;
using IonicApi.Modes;
using IonicApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList;

namespace IonicApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IMessageRepository _messageRepository;

        public MessageController(IUserRepository userRepository, IMapper mapper , IMessageRepository messageRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            //注册AutoMapper，相互映射dto用
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _messageRepository = messageRepository ?? throw new ArgumentNullException(nameof(messageRepository));
        }

        /// <summary>
        /// 获取用户id为userId收到的信件
        /// </summary>
        /// <param name="authtoken">登录令牌</param>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetReceiveMessage(string authtoken, int userId, int page = 1, int count = 10)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken)) //用户登录的时候会生成authtoken令牌
            {
                var isReceive = await _messageRepository.MessageReceiveExistsAsync(userId);  //该用户是否收到信件
                if (isReceive)
                {
                    var entity = await _messageRepository.GetMessagesReceiveAsync(userId);
                    IPagedList<PeMessage> list = new PagedList<PeMessage>(entity, page, count);
                    ret.info = _mapper.Map<IEnumerable<MessageDto>>(entity);
                    ret.pagecount = list.PageCount;
                    ret.recordcount = list.TotalItemCount;
                    ret.isfirst = list.IsFirstPage;
                    ret.hasnext = list.HasNextPage;
                    ret.retcode = 0;
                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "参数错误,没有收到信件";
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
        /// 获取用户id为userId已放入回收站中的收到信件
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="userId"></param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetRecycleMessage(string authtoken, int userId, int page = 1, int count = 10)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken)) //用户登录的时候会生成authtoken令牌
            {
                var isReceiveRecycle = await _messageRepository.MessageRecycleExistsAsync(userId);  //该用户是否收到信件
                if (isReceiveRecycle)
                {
                    var entity = await _messageRepository.GetMessagesRecycleAsync(userId);
                    IPagedList<PeMessage> list = new PagedList<PeMessage>(entity, page, count);
                    ret.info = _mapper.Map<IEnumerable<MessageDto>>(entity);
                    ret.pagecount = list.PageCount;
                    ret.recordcount = list.TotalItemCount;
                    ret.isfirst = list.IsFirstPage;
                    ret.hasnext = list.HasNextPage;
                    ret.retcode = 0;
                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "参数错误或回收站为空";
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
        /// 获取用户id为userId发送的信件
        /// </summary>
        /// <param name="authtoken">登录令牌</param>
        /// <param name="userId">用户ID</param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetSendMessage(string authtoken, int userId, int page = 1, int count = 10)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken)) //用户登录的时候会生成authtoken令牌
            {
                var isSend = await _messageRepository.MessageSendExistsAsync(userId);  //该用户是否存在发送的信件
                if (isSend)
                {
                    var entity = await _messageRepository.GetMessagesSendAsync(userId);
                    IPagedList<PeMessage> list = new PagedList<PeMessage>(entity, page, count);
                    ret.info = _mapper.Map<IEnumerable<MessageDto>>(entity);
                    ret.pagecount = list.PageCount;
                    ret.recordcount = list.TotalItemCount;
                    ret.isfirst = list.IsFirstPage;
                    ret.hasnext = list.HasNextPage;
                    ret.retcode = 0;
                }
                else
                {
                    ret.retcode = 11;
                    ret.message = "参数错误或没有发出的信件";
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
        /// 通过邮件的id获取具体的邮件
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id">邮件id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetMessageById(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken)) //用户登录的时候会生成authtoken令牌
            {
                var message = await _messageRepository.MessageExistsAsync(id);
                if (message)
                {
                    var entity = _messageRepository.GetMessage(id);
                    ret.retcode = 0;
                    ret.info = _mapper.Map<PeMessage>(entity);
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


    }
}
