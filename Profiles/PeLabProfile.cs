using AutoMapper;
using IonicApi.Dtos;
using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Profiles
{
    public class PeLabProfile : Profile
    {
        public PeLabProfile()
        {
            CreateMap<PeLab, PeLabDto>();

        }
    }

}
