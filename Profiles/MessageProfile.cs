using AutoMapper;
using IonicApi.Dtos;
using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Profiles
{
    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            CreateMap<PeMessage, MessageDto>();
            CreateMap<PeMessage, MessageAddDto>();
            CreateMap<PeMessageReceive, MessageReceiveAddDto>();

            CreateMap<MessageDto, PeMessage>();
            CreateMap<MessageAddDto, PeMessage>();
            CreateMap<MessageReceiveAddDto,PeMessageReceive>();
        }
    }

}
