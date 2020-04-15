using AutoMapper;
using IonicApi.Dtos;
using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<PeCourse, CourseDto>();
            CreateMap<CourseAddDto, PeCourse>();

            CreateMap<PeTest, TestDto>();
            CreateMap<TestAddDto, PeTest>();
            CreateMap<TestEditDto, PeTest>();

            CreateMap<PeCourseStudent, CourseStudentDto>();

            CreateMap<PeUser, StudentDto>();
            CreateMap<PeCourseStudent, CJHZDto>().ForMember(
                destinationMember: dest => dest.FinalGrade,
                memberOptions: opt => opt.MapFrom(mapExpression: src => Math.Round(
                (src.Course.Psycj * src.Sycj / 100)+ 
                (src.Course.Pzycj * src.Zycj / 100)+ 
                (src.Course.Pkscj1 * src.Kscj1 / 100)+
                (src.Course.Pkscj2 * src.Kscj2 / 100) +
                (src.Course.Pkscj3 * src.Kscj3 / 100) +
                (src.Course.Pkscj4 * src.Kscj4 / 100) +
                (src.Course.Pkscj5 * src.Kscj5 / 100)))
            );

            CreateMap<PeResource, ResourceDto>();
            CreateMap<PePaperOutputTask, PaperOutputTaskDto>();
        }
    }
}
