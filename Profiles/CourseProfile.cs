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
            CreateMap<PeCourseStudent, CJHZDto>();
        }
    }
}
