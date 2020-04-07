using IonicApi.Models;
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
        Task<PeCourse> GetCourse(int courseId);
        Task<bool> CourseExistAsync(int courseId);
        void AddCourse(int userId,PeCourse peCourse);
        void UpdateCourse(int courseId, PeCourse peCourse);
        void DeleteCourse(int id);
        Task<bool> SaveAsync();

        Task<PeTest> GetTestAsync(int id);
        Task<IEnumerable<PeTest>> GetTestsAsync(int courseId,int mode);
        void AddTest(int courseId, PeTest test);
        void UpdateTest(int testId, PeTest test);
        void DeleteTest(PeTest test);
        Task<bool> TestExistsAsync(int testId);

        Task<IEnumerable<PeCourseStudent>> GradeListAsync(int courseId);
        Task<IEnumerable<PeCourseStudent>> GradeAsync(int courseId, int id);
        Task<bool> GradeExists(int courseId);

        Task<IEnumerable<PeResource>> GetResourcesAsync(int courseId, int parentId);
        Task<IEnumerable<PeResource>> GetResourcesAsync(int courseId, int parentId, string keyword);
        Task<bool> ResourceExistsAsync(int id);
        Task<PeResource> GetResourceAsync(int id);
        void AddResource(int courseId, PeResource peResource);
        void UpdateResource(int Id, PeResource peResource);
        void DeleteResource(int id);
    }
}
