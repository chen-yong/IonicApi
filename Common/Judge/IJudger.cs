using IonicApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Common.Judge
{
    public interface IJudger
    {
        JudgeResult Judge(UTQProxy userTestQuestion);
    }
}
