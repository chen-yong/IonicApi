using IonicApi.Common;
using IonicApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly PureExam_DevContext _context;
        public TestRepository(PureExam_DevContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddTest(int courseId, Models.PeTest test)
        {
            if (test == null)
            {
                throw new ArgumentNullException(nameof(test));
            }
            //test.CreateUserId=
            test.CreateTime = DateTime.Now;
            test.IsOpen = true;
            if (test.TimeLimit > 0)
            {
                test.AutoSubmitOnTimeLimit = true;
            }
            test.Nid = GUIDUtility.GenerateCharID();
            _context.PeTest.Add(test);
        }

        public void DeleteTest(Models.PeTest test)
        {
            throw new NotImplementedException();
        }

        public async Task<Models.PeTest> GetTestAsync(int id)
        {
            return await _context.PeTest.Where(e => e.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Models.PeTest>> GetExercisesAsync(int courseId)
        {
            //Mode=1考试 Mode=2练习 Mode=3作业 Mode=4实验
            return await _context.PeTest.Where(e => e.CourseId == courseId && e.Mode == 2 && !e.IsDel).OrderBy(e => e.Id).ToListAsync();
        }
        public async Task<IEnumerable<Models.PeTest>> GetTestsAsync(int courseId)
        {
            //Mode=1考试 Mode=2练习 Mode=3作业 Mode=4实验
            return await _context.PeTest.Where(e => e.CourseId == courseId && e.Mode == 3 && !e.IsDel).OrderBy(e => e.Id).ToListAsync();
        }
        public async Task<IEnumerable<Models.PeTest>> GetLabsAsync(int courseId)
        {
            //Mode=1考试 Mode=2练习 Mode=3作业 Mode=4实验
            return await _context.PeTest.Where(e => e.CourseId == courseId && e.Mode == 4 && !e.IsDel).OrderBy(e => e.Id).ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public async Task<bool> TestExistsAsync(int testId)
        {
            return await _context.PeTest.AnyAsync(e => e.Id == testId);
        }

        public void UpdateTest(int testId, Models.PeTest test)
        {
            //throw new NotImplementedException();
        }
    }
}