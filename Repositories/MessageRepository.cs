using IonicApi.Models;
using IonicApi.Repositories;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using IonicApi.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IonicApi.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly PureExam_DevContext _context;
        public MessageRepository(PureExam_DevContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// 查询某个用户收到的所有邮件
        /// </summary>
        /// <param name="receiverId">用户Id</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeMessage>> GetMessagesReceiveAsync(int receiverId)
        {
            //select * from PE_Message where Id in(select MessageId from PE__MessageReceive where Receiver=receiverId )
            var messageList = from a in _context.PeMessage
                              where (from b in _context.PeMessageReceive where b.Receiver == receiverId && !b.IsDel
                                     && !b.IsRecycle select b.MessageId).Contains(a.Id)
                              select a;
            messageList = messageList.OrderByDescending(e => e.SendTime);
            return await messageList.ToListAsync();
        }

        /// <summary>
        /// 查询某个用户收到的在回收站中的邮件
        /// </summary>
        /// <param name="receiverId">用户Id</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeMessage>> GetMessagesRecycleAsync(int receiverId)
        {
            var messageList = from a in _context.PeMessage
                              where (from b in _context.PeMessageReceive
                                     where b.Receiver == receiverId && !b.IsDel && b.IsRecycle
                                     select b.MessageId).Contains(a.Id)
                              select a;
            messageList = messageList.OrderByDescending(e => e.SendTime);
            return await messageList.ToListAsync();
        }

        /// <summary>
        /// 查询某个用户发出的所有邮件
        /// </summary>
        /// <param name="receiverId">用户Id</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeMessage>> GetMessagesSendAsync(int receiverId)
        {
            var messageList = from a in _context.PeMessage
                              where (a.Sender == receiverId && !a.IsRecycle && !a.IsDel)
                              select a;
            messageList = messageList.OrderByDescending(e => e.SendTime);
            return await messageList.ToListAsync();
        }

        /// <summary>
        /// 根据信件的id判断具体某信是否存在
        /// </summary>
        /// <param name="id">信件的id（PE_Message表中的Id）</param>
        /// <returns></returns>
        public async Task<bool> MessageExistsAsync(int id)
        {
            return await _context.PeMessage.AnyAsync(e => (e.Id == id));
        }

        /// <summary>
        /// 根据接收人ID判断是否该用户收到信件
        /// </summary>
        /// <param name="receiverId">收件人的Id</param>
        /// <returns></returns>
        public async Task<bool> MessageReceiveExistsAsync(int receiverId)
        {
            return await _context.PeMessageReceive.AnyAsync(e => (e.Receiver == receiverId));
        }

        /// <summary>
        /// 根据接收人ID判断是否该用户的回收站里是否存在收到的信件
        /// </summary>
        /// <param name="receiverId"></param>
        /// <returns></returns>
        public async Task<bool> MessageRecycleExistsAsync(int receiverId)
        {
            return await _context.PeMessageReceive.AnyAsync(e => (e.Receiver == receiverId && e.IsRecycle));
        }

        /// <summary>
        /// 根据发收人ID判断是否存在发送的信件
        /// </summary>
        /// <param name="senderId"></param>
        /// <returns></returns>
        public async Task<bool> MessageSendExistsAsync(int senderId)
        {
            return await _context.PeMessage.AnyAsync(e => (e.Sender == senderId));
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
        /// <summary>
        /// 根据信件id获取信件信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  PeMessage GetMessage(int id)
        {
            return _context.PeMessage.SingleOrDefault(e => (e.Id == id));
        }

    }
}