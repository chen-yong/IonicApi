using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface IPaperOutputTaskRepository
    {
        Task<IEnumerable<PePaperOutputTask>> GetPaperTasksAsync(int userId);
        Task<IEnumerable<PePaperOutputTask>> GetPaperTasksAsync(int userId, string keyword);
        Task<PePaperOutputTask> GetPaperTaskAsync(int Id);
        void AddPaperTask(int courseId, PePaperOutputTask paperOutput);
        void UpdatePaperTask(int id, PePaperOutputTask paperOutput);
        void DeletePaperTask(PePaperOutputTask paperOutput);
        Task<bool> PaperTaskExists(string name);
        Task<bool> SaveAsync();
    }
}
