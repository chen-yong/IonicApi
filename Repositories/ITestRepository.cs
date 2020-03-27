using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface ITestRepository
    {
        Task<Models.PeTest> GetTestAsync(int id);
        Task<IEnumerable<Models.PeTest>> GetTestsAsync(int courseId);
        Task<IEnumerable<Models.PeTest>> GetLabsAsync(int courseId);
        Task<IEnumerable<Models.PeTest>> GetExercisesAsync(int courseId);
        void AddTest(int courseId, Models.PeTest test);
        void UpdateTest(int testId, Models.PeTest test);
        void DeleteTest(Models.PeTest test);
        Task<bool> TestExistsAsync(int testId);
        Task<bool> SaveAsync();
    }
}
