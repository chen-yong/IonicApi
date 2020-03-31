using AutoMapper;
using IonicApi.Dtos;
using IonicApi.Models;

namespace IonicApi.Profiles
{
    public class CourseStudentProfile : Profile
    {
        public  CourseStudentProfile()
        { 
            CreateMap<PeCourseStudent, CourseStudentDto>();
        }
    }
}
