using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface IPeDrawPlotRepository
    {
        Task<IEnumerable<PeDrawPlot>> GetPeDrawPlotsAsync(int createdUserId);
        Task<bool> SaveAsync();
    }
}
