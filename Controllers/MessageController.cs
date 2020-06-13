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
                    var entity = await _messageRepository.GetMessageAsync(id);
                    ret.retcode = 0;
                    ret.info = entity;
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
        /// 根据邮件id获取MessageReceive数据
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetMessageReceiveById(string authtoken, int Id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken)) //用户登录的时候会生成authtoken令牌
            {
                var message = await _messageRepository.MessageExistsAsync(Id);
                if (message)
                {
                    var entity = await _messageRepository.GetMessageReceiveAsync(Id);
                    ret.retcode = 0;
                    ret.info = entity;
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
        /// 把回信放到回收站中
        /// </summary>
        /// <param name="authtoken">令牌</param>
        /// <param name="id">邮件id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeleteMessagetoRecycle(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessageReceive entity = await _messageRepository.GetMessageReceiveAsync(id);
                if (entity != null)
                {
                    entity.IsRecycle = true;
                    await _userRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "邮件成功放入回收站";
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
        /// 将邮件软删除删除
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeleteMessagetoEnd(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessageReceive entity = await _messageRepository.GetMessageReceiveAsync(id);
                if (entity != null)
                {
                    entity.IsDel = true;
                    await _userRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "邮件成功彻底删除";
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
        /// 将邮件从回收站中拉回收件箱中
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> MessageBackReceive(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessageReceive entity = await _messageRepository.GetMessageReceiveAsync(id);
                if (entity != null)
                {
                    entity.IsRecycle = false;
                    await _userRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "邮件离开回收站回到收件箱中";
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
        /// 根据文件id将文件标为重要
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> MessageImportant(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessage entity = await _messageRepository.GetMessageAsync(id);
                if (entity != null)
                {
                    entity.IsImportant = true;
                    await _messageRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "该邮件已经标为重要文件";
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
        /// 根据邮件id将邮件标为不重要邮件
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> MessageNoImportant(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessage entity = await _messageRepository.GetMessageAsync(id);
                if (entity != null)
                {
                    entity.IsImportant = false;
                    await _userRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "该邮件已经变成不重要文件";
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
        /// 添加PeMessage邮件(添加的同时修改code和添加对应的receive，也就是说与get方法NewCodeAndAddPeMessageReceive联用)
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="addMessage"></param>
        /// <returns></returns>  123
        [HttpPost]
        public async Task<ActionResult> AddMessage(string authtoken, [FromBody] MessageAddDto addMessage)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                var entity = _mapper.Map<PeMessage>(addMessage);
                //新账号
                entity.SendTime = DateTime.Now;
                entity.IsDel = false;
                entity.Code = "1"; //后面前端一创建成功就立马调用接口把code改掉
                entity.IsRecycle = false;
                ret.retcode = 0;
                _messageRepository.AddPeMessage(entity);
                ret.message = "新增PeMessage邮件成功";
                await _messageRepository.SaveAsync();
                //返回新建的这个PeMessage数据到ret.info里面
                var entity2 = await _messageRepository.GetMessagesSendAsync(addMessage.Sender);
                ret.info = _mapper.Map<IEnumerable<MessageDto>>(entity2).First();     
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 添加PeMessage邮件后将code改为与id一致并且创建相对应的PeMessageReceive表数据
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id">邮件id（MessageId）</param>
        /// <param name="userid">收件人id（Receiver）</param>
        /// <returns></returns> 
        [HttpGet]
        public async Task<ActionResult> NewCodeAndAddPeMessageReceive(string authtoken, int id, int userid)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessage entity = await _messageRepository.GetMessageAsync(id);
                PeUser user = await _userRepository.GetUserAsync(userid);
                if (user != null && entity != null)
                {
                    entity.Code = entity.Id.ToString();
                    ret.retcode = 0;
                    user.PeMessageReceive.Add(new PeMessageReceive
                    {
                        MessageId = id,
                        Receiver = userid,
                        IsReaded = false,
                        IsDel = false,
                        IsRecycle = false
                    });
                    ret.message = "该邮件的code已经与邮件id一致,并且相对应的PeMessageReceive表数据建立";
                    await _userRepository.SaveAsync();
                    await _messageRepository.SaveAsync();
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
        /// 根据邮件id将邮件设为已读
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> MessageHasReaded(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessageReceive entity = await _messageRepository.GetMessageReceiveAsync(id);
                if (entity != null)
                {
                    entity.IsReaded = true;
                    await _messageRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "该邮件已读";
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
        /// 将自己发送的文件软删除PeMessage中的isDel设为true
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeleteMessageHasSend(string authtoken, int id)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessage entity = await _messageRepository.GetMessageAsync(id);
                if (entity != null)
                {
                    entity.IsDel = true;
                    await _messageRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "该邮件已删除";
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
        ///根据关键字和班级获取通讯录名单（用户名或真实名包含关键字的 【有效账户中老师和同班的人】）
        /// </summary>
        /// <param name="authtoken">登录令牌</param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="property00">班级</param>
        /// <param name="keyword">搜索的关键字</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetTongxunlu(string authtoken, string property00, string keyword, int page = 1, int count = 10)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken)) //用户登录的时候会生成authtoken令牌
            {
                var entity = await _userRepository.GetUsersTongxunAsync(authtoken, property00, keyword);
                IPagedList<PeUser> list = new PagedList<PeUser>(entity, page, count);
                ret.info = _mapper.Map<IEnumerable<UserDto>>(entity);
                ret.pagecount = list.PageCount;
                ret.recordcount = list.TotalItemCount;
                ret.isfirst = list.IsFirstPage;
                ret.hasnext = list.HasNextPage;
                ret.retcode = 0;
                ret.message = "获得了所有可用老师的信息";
            }
            else
            {
                ret.retcode = 13;
                ret.message = ret.debug = "登录令牌失效";
            }
            return Ok(ret);
        }

        /// <summary>
        /// 改变PeMessage邮件的code
        /// </summary>
        /// <param name="authtoken"></param>
        /// <param name="id">PeMessage邮件的id</param>
        /// <param name="code">code需要改变的值</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> ChangeCode(string authtoken, int id , string code)
        {
            MapiData ret = new MapiData();
            if (AuthtokenUtility.ValidToken(authtoken))
            {
                PeMessage entity = await _messageRepository.GetMessageAsync(id);
                if (entity != null)
                {
                    entity.Code = code;
                    await _messageRepository.SaveAsync();
                    ret.retcode = 0;
                    ret.message = "该邮件的code已经改变";
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
