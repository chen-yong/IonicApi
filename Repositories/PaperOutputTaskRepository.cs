using IonicApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public class PaperOutputTaskRepository : IPaperOutputTaskRepository
    {
        private readonly PureExam_DevContext _context;
        public PaperOutputTaskRepository(PureExam_DevContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddPaperTask(PePaperOutputTask paperOutput)
        {
            _context.PePaperOutputTask.Add(paperOutput);
        }

        public void DeletePaperTask(PePaperOutputTask paperOutput)
        {
            _context.PePaperOutputTask.Remove(paperOutput);
        }

        public async Task<PePaperOutputTask> GetPaperTaskAsync(int Id)
        {
            return await _context.PePaperOutputTask.SingleOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<PePaperOutputTask>> GetPaperTasksAsync(int userId)
        {
            return await _context.PePaperOutputTask.Where(e => e.CreateUser == userId).ToListAsync();
        }

        public async Task<IEnumerable<PePaperOutputTask>> GetPaperTasksAsync(int courseId, int userId, string keyword)
        {
            var tasks = _context.PePaperOutputTask.Where(e => e.CreateUser == userId && e.Test.CourseId == courseId && e.Test.Mode != Config.TestMode.Test);
            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.Trim();
                tasks = tasks.Where(e => e.Name.Contains(keyword.Trim()));
            }
            return await tasks.OrderByDescending(e => e.CreateTime).ToListAsync();
        }

        public async Task<bool> PaperTaskExists(string name)
        {
            return await _context.PePaperOutputTask.AnyAsync(e => e.Name == name);
        }

        public void UpdatePaperTask(int id, PePaperOutputTask paperOutput)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}
