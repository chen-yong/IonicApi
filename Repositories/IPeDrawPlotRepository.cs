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
        /// 获取题型列表
        /// </summary>
        /// <param name="drawplotId">手工组卷Id</param>
        /// <returns></returns>
        Task<IEnumerable<PeUserTestPaperTopic>> GetTopicListAsync(int drawplotId);

        /// <summary>
        /// 获取题目
        /// </summary>
        /// <param name="labId">策略id</param>
        /// <param name="topicList">题型Id列表</param>
        /// <param name="difficultyList">难度id列表</param>
        /// <returns></returns>
        Task<IEnumerable<PeQuestion>> GetQuesListAsync(int labId, string topicList, string difficultyList);

        /// <summary>
        /// 添加试卷记录信息
        /// <param name="entity"></param>
        /// </summary>
        int AddUserTestPaper(PeUserTestPaper entity);
        /// <summary>
        /// 添加题型记录信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int AddUserTestPaperTopic(PeUserTestPaperTopic entity);
        /// <summary>
        /// 添加题目记录
        /// </summary>
        /// <param name="entity"></param>
        void AddUserTestPaperQues(PeUserTestPaperQuestions entity);
        /// <summary>
        /// 获取指定试卷中题型表中题型信息
        /// </summary>
        /// <param name="topicId"></param>
        /// <returns></returns>
        PeUserTestPaperTopic getByTopicId(int topicId, int paperId);
        /// <summary>
        /// 根据id取题目
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PeQuestion GetQuestion(int id);
        /// <summary>
        /// 改变Topic的排序
        /// </summary>
        /// <param name="model"></param>
        void updateTopicOrd(PeUserTestPaperTopic model);
        /// <summary>
        /// 组卷中是否包含此题
        /// </summary>
        /// <param name="quesId"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        PeUserTestPaperQuestions IsPaperContains(int quesId, int Id);
        /// <summary>
        /// 保存试卷时，更新试卷中题目排列顺序
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="rank"></param>
        void udpateRank(PeUserTestPaperQuestions entity, int rank);
        Task<bool> SaveAsync();
        bool SaveChanges();

    }
}
