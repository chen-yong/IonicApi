using AutoMapper;
using IonicApi.Dtos;
using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<PeUser, UserDto>();
            CreateMap<UserAddDto, PeUser>();
            CreateMap<UserEditDto, PeUser>();
            CreateMap<PeUser, UserEditDto>();
            CreateMap<PeUser, StudentDto>();
        }
    }

}
