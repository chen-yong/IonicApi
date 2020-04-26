using IonicApi.Dtos;
using System.Threading.Tasks;

namespace IonicApi.Common.Judge
{
    public interface IJudgerAsync : IJudger
    {
        Task<JudgeResult> JudgeAsync(UTQProxy userTestQuestion);
    }
}
