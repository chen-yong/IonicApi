using AutoMapper;
using IonicApi.Dtos;
using IonicApi.Models;

namespace IonicApi.Profiles
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<PeTest, TestDto>();
            CreateMap<TestAddDto, PeTest>();
            CreateMap<TestEditDto, PeTest>();
        }
    }
}
