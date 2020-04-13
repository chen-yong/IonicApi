using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface IBaseRepository
    {
        Task<bool> SaveAsync();
    }
}
