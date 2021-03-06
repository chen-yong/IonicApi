﻿using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface IMessageRepository
    {
        Task<IEnumerable<PeMessage>> GetMessagesReceiveAsync(int receiverId);
        Task<IEnumerable<PeMessage>> GetMessagesSendAsync(int receiverId);
        Task<IEnumerable<PeMessage>> GetMessagesRecycleAsync(int receiverId);
        Task<bool> MessageExistsAsync(int id);
        Task<bool> MessageSendExistsAsync(int senderId);
        Task<bool> MessageReceiveExistsAsync(int receiverId);
        Task<bool> MessageRecycleExistsAsync(int receiverId);


        void AddPeMessage(PeMessage message);
        void AddPeMessageReceive(PeMessageReceive messageReceive);

        Task<bool> SaveAsync();

        Task<PeMessage> GetMessageAsync(int Id);
        Task<PeMessageReceive> GetMessageReceiveAsync(int Id);


    }
}