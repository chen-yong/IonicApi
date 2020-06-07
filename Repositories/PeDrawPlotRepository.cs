using IonicApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public class PeDrawPlotRepository : IPeDrawPlotRepository
    {
        private readonly PureExam_DevContext _context;
        public PeDrawPlotRepository(PureExam_DevContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<PeDrawPlot>> GetPeDrawPlotsAsync(int createdUserId)
        {
            return await _context.PeDrawPlot.Where(e => e.CreateUserId == createdUserId && e.Dptype == "TestPaper" && !e.IsDel).ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}
