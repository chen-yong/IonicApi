﻿using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface ICourseRepository
    {
        Task<IEnumerable<PeCourse>> GetCoursesAsync(string authtoken);
        Task<IEnumerable<PeCourse>> GetCourseAsync(int courseId);
        Task<bool> CourseExistAsync(int courseId);
        void AddCourse(int userId,PeCourse peCourse);
        void UpdateCourse(int courseId, PeCourse peCourse);
        void DeleteCourse(int id);
        Task<bool> SaveAsync();
    }
}
