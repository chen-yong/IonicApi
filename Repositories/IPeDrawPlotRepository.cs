using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface IPeDrawPlotRepository
    {
        /// <summary>
        /// 获取手工组卷列表
        /// </summary>
        /// <param name="createdUserId"></param>
        /// <returns></returns>
        Task<IEnumerable<PeDrawPlot>> GetPeDrawPlotsAsync(int createdUserId);

        /// <summary>
        /// 获取试卷
        /// </summary>
        /// <param name="drawplotId">策略id</param>
        /// <returns></returns>
        Task<IEnumerable<PeUserTestPaper>> GetPaperAsync(int drawplotId);
        PeUserTestPaper GetPaper(int drawplotId);

        /// <summary>
        /// 获取手工组卷的题型列表
        /// </summary>
        /// <param name="drawplotId">手工组卷Id</param>
        /// <returns></returns>
        Task<IEnumerable<PeUserTestPaperTopic>> GetTopicListAsync(int drawplotId);

        /// <summary>
        /// 获取策略对应的题库具有的题型列表
        /// </summary>
        /// <param name="labId">策略对应的题库Id</param>
        /// <returns></returns>
        Task<IEnumerable<PeTopic>> GetDrawPlotTopicListAsync(int labId);

        /// <summary>
        /// 获取题目
        /// </summary>
        /// <param name="labId">策略id</param>
        /// <param name="topicList">题型Id列表</param>
        /// <param name="difficultyList">难度id列表</param>
        /// <returns></returns>
        Task<IEnumerable<PeQuestion>> GetQuesListAsync(int labId, string topicList, string difficultyList);

        Task<bool> SaveAsync();

    }
}
