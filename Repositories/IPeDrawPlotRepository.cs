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
        Task<IEnumerable<PeTopic>> GetLabTopicListAsync(int labId);

        /// <summary>
        /// 根据题库id获取题库的信息（名字）
        /// </summary>
        /// <param name="labId"></param>
        /// <returns></returns>
        Task<PeLab> GetPeLabAsync(int labId);

        /// <summary>
        /// 获取题目
        /// </summary>
        /// <param name="labId">策略id</param>
        /// <param name="topicList">题型Id列表</param>
        /// <param name="difficultyList">难度id列表</param>
        /// <returns></returns>
        Task<IEnumerable<PeQuestion>> GetQuesListAsync(int labId, string topicList, string difficultyList);

        /// <summary>
        /// 根据策略id获取组卷的题目
        /// </summary>
        /// <param name="drawplotId"></param>
        /// <returns></returns>
        Task<IEnumerable<PeUserTestPaperQuestions>> GetTextPaperQuestionListAsync(int drawplotId);

        /// <summary>
        /// 根据id获取题目详情
        /// </summary>
        /// <param name="labId"></param>
        /// <returns></returns>
        Task<PeQuestion> GetPeQuestion(int questionId);

        Task<PeKnowledge> GetPeKnowledgeAsync(int knowledgeId);

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
        Task<PeUserTestPaperTopic> GetByTopicIdAsync(int topicId, int paperId);
        /// <summary>
        /// 根据id取题目
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PeQuestion GetQuestion(int id);
        /// <summary>
        /// 根据id取题型
        /// </summary>
        /// <param name="id"></param>
        Task<PeTopic> GetTopicAsync(int id);
        /// <summary>
        /// 改变Topic的排序
        /// </summary>
        /// <param name="model"></param>
        void updateTopicOrdAsync(PeUserTestPaperTopic model);
        /// <summary>
        /// 组卷中是否包含此题
        /// </summary>
        /// <param name="quesId"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<PeUserTestPaperQuestions> IsPaperContainsAsync(int quesId, int Id);
        /// <summary>
        /// 保存试卷时，更新试卷中题目排列顺序
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="rank"></param>
        void udpateRankAsync(PeUserTestPaperQuestions entity, int rank);
        Task<bool> SaveAsync();
        bool SaveChanges();
    }
}
