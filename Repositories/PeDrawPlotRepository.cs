using IonicApi.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            PeUserTestPaper entity = _context.PeUserTestPaper.Where(e => e.DrawplotId == drawplotId && e.IsDel == false).FirstOrDefault();
            return entity;
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
        /// 获取题目列表
        /// </summary>
        /// <param name="labId">策略id</param>
        /// <param name="topicId">题型Id</param>
        /// <param name="difficulty">难度id</param>
        public async Task<IEnumerable<PeQuestion>> GetQuesListAsync(int labId,string topicList,string difficultyList)
        {
            var questionList =  _context.PeQuestion.Where(e => e.LabId == labId && !e.IsDel);
            //int num1 = Regex.Matches(topicList, ",").Count;
            //题型列表
            //if (!string.IsNullOrEmpty(topicList))
            //{
            //    if (num1 < 1)
            //    {
            //        questionList.Where(e => e.TopicId.ToString() == topicList);
            //    }
            //    else 
            //    {
            //        string[] topicArr = topicList.Split(',');
            //        questionList.Contains(topicArr);
            //    }
            //}

            //if (topicId > 0)
            //{
            //    questionList.Where(e => e.TopicId == topicId).OrderBy(e=>e.TopicId);
            //}
            //if (difficulty > 0)
            //{
            //    questionList.Where(e => e.Difficulty == difficulty);
            //}
            if (!string.IsNullOrEmpty(topicList))
            {
                questionList.Where(e => e.TopicId.ToString().Contains(topicList));
            }
            if (!string.IsNullOrEmpty(difficultyList))
            {
                questionList.Where(e => e.Difficulty.ToString().Contains(difficultyList));
            }
            questionList.GroupBy(e => e.TopicId);
            return await questionList.ToListAsync(); 
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

    }
}
