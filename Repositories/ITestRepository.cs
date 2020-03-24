using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface ITestRepository
    {
        Task<PeTest> GetTestAsync(int id);
        Task<IEnumerable<PeTest>> GetTestsAsync(int courseId);
        void AddTest(int courseId,PeTest test);
        void UpdateTest(int testId, PeTest test);
        void DeleteTest(PeTest test);
        Task<bool> TestExistsAsync(int testId);
        Task<bool> SaveAsync();
    }
}
