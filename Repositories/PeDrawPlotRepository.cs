using IonicApi.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text.RegularExpressions;
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

        public async Task<IEnumerable<PeUserTestPaper>> GetPaperAsync(int drawplotId)
        {
            return await _context.PeUserTestPaper.Where(e => e.DrawplotId == drawplotId && e.IsDel == false).ToListAsync();
        }
        public PeUserTestPaper GetPaper(int drawplotId)
        {
            return _context.PeUserTestPaper.Where(e => e.DrawplotId == drawplotId && e.IsDel == false).FirstOrDefault();
        }

        /// <summary>
        /// 获取题型列表
        /// </summary>
        /// <param name="drawplotId">手工组卷Id</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeUserTestPaperTopic>> GetTopicListAsync(int drawplotId)
        {
            int id=_context.PeUserTestPaper.SingleOrDefault(e => e.DrawplotId == drawplotId && !e.IsDel).Id;
            return await _context.PeUserTestPaperTopic.Where(e => e.PaperId == id && !e.IsDel).OrderBy(e=>e.TopicId).ToListAsync();
        }

        /// <summary>
        /// 计算字符串包含子串的个数
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="substring">子串</param>
        /// <returns>个数</returns>
        public int SubstringCount(string str, string substring)
        {
            int countStr = 0;
            //字符串是否含有子串
            if (str.Contains(substring))
            {
                //用空替换所有出现的子串
                string strRelaced = str.Replace(substring,"");
                //（字符串长度-替换后字符串的长度）/子串的长度
                countStr = (str.Length - strRelaced.Length) / substring.Length;
            }
            return countStr;
        }

        /// <summary>
        /// 获取题目列表
        /// </summary>
        /// <param name="labId">策略id</param>
        /// <param name="topicId">题型Id</param>
        /// <param name="difficulty">难度id</param>
        public async Task<IEnumerable<PeQuestion>> GetQuesListAsync(int labId,string topicList,string difficultyList)
        {
            //根据策略id过滤题目
            var questionList = _context.PeQuestion.Where(e => e.LabId == labId && !e.IsDel);
            var questions = from a in _context.PeQuestion where a.TopicId.ToString().Contains(topicList) select a;
            string topicStr = "";
            string difficultyStr = "";
            //题型id 用‘,’隔开
            if (!string.IsNullOrEmpty(topicList))
            {
                if (SubstringCount(topicList, ",") == 0)
                {
                    topicStr = topicList + ",";
                }
                else
                {
                    string[] topicArr = topicList.Split(',');
                    foreach (var item in topicArr)
                    {
                        topicStr += item + ",";
                    }
                }
                //去掉最后一位","
                topicStr = topicStr.Substring(0, topicStr.Length - 1);
            }
            if (!string.IsNullOrEmpty(topicStr))
            {
                string[] topicStrArr = topicStr.Split(',');
                questionList = from a in questionList where topicStrArr.Contains(a.TopicId.ToString()) select a;
            }
            //难度id 用“,”隔开
            if (!string.IsNullOrEmpty(difficultyList))
            {
                if (SubstringCount(difficultyList, ",") == 0)
                {
                    difficultyStr = difficultyList + ",";
                }
                else
                {
                    string[] diffArr = difficultyList.Split(',');
                    foreach (var item in diffArr)
                    {
                        difficultyStr += item + ",";
                    }
                }
                //去掉最后一位","
                difficultyStr = difficultyStr.Substring(0, difficultyStr.Length - 1);
            }
            if (!string.IsNullOrEmpty(difficultyStr))
            {
                string[] difficultyStrArr = difficultyStr.Split(',');
                questionList = from a in questionList where difficultyStr.Contains(a.Difficulty.ToString()) select a;
            }
            //排序（题型，题序）
            questionList.OrderBy(e=>e.TopicId).ThenBy(e=>e.Ord);
            return await questionList.ToListAsync(); 
        }

        /// <summary>
        /// 添加试卷记录信息
        /// <param name="entity"></param>
        /// </summary>
        public int AddUserTestPaper(PeUserTestPaper entity)
        {
            _context.PeUserTestPaper.Add(entity);
            SaveChanges();
            int newId = entity.Id;
            return newId;
        }

        /// <summary>
        /// 添加题型记录信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int AddUserTestPaperTopic(PeUserTestPaperTopic entity)
        {
            _context.PeUserTestPaperTopic.Add(entity);
            SaveChanges();
            int newId = entity.Id;
            return newId;
        }
        /// <summary>
        /// 添加题目记录
        /// </summary>
        /// <param name="entity"></param>
        public void AddUserTestPaperQues(PeUserTestPaperQuestions entity)
        {
            _context.PeUserTestPaperQuestions.Add(entity);
            SaveChanges();
        }

        /// <summary>
        /// 获取指定试卷中题型表中题型信息
        /// </summary>
        /// <param name="topicId"></param>
        /// <returns></returns>
        public PeUserTestPaperTopic getByTopicId(int topicId, int paperId)
        {
            return _context.PeUserTestPaperTopic.Where(e => e.TopicId == topicId && e.PaperId == paperId && e.IsDel == false).FirstOrDefault();
        }
        /// <summary>
        /// 根据id取题目
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PeQuestion GetQuestion(int id)
        {
            return _context.PeQuestion.SingleOrDefault(e => e.Id == id);
        }
        /// <summary>
        /// 改变Topic的排序
        /// </summary>
        /// <param name="model"></param>
        public void updateTopicOrd(PeUserTestPaperTopic model)
        {
            PeUserTestPaperTopic entity = _context.PeUserTestPaperTopic.Where(e => e.Id == model.Id && e.IsDel == false).Single();
            entity.Ord = model.Ord;
            SaveChanges();
        }
        /// <summary>
        /// 组卷中是否包含此题
        /// </summary>
        /// <param name="quesId"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public PeUserTestPaperQuestions IsPaperContains(int quesId, int Id)
        {
            return _context.PeUserTestPaperQuestions.Where(e => e.QuestionId == quesId && e.PaperId == Id && e.IsDel == false).FirstOrDefault();
        }
        /// <summary>
        /// 保存试卷时，更新试卷中题目排列顺序
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="rank"></param>
        public void udpateRank(PeUserTestPaperQuestions entity, int rank)
        {
            PeUserTestPaperQuestions questionEntity = _context.PeUserTestPaperQuestions.Where(e => e.Id == entity.Id && e.IsDel == false).Single();
            questionEntity.Rank = rank;
            questionEntity.Ord = rank.ToString();
            SaveChanges();
        }
        /// <summary>
        /// 异步保存
        /// </summary>
        /// <returns></returns>
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        public  bool SaveChanges()
        {
            return  _context.SaveChanges() >= 0;
        }

    }
}
