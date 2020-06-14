using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    /// <summary>
    /// 题型
    /// </summary>
    public class PaperTopicDto
    {
        //public PaperTopicDto()
        //{
        //    PeUserTestPaperQuestions = new HashSet<PeUserTestPaperQuestions>();
        //}

        //public int Id { get; set; }
        /// <summary>
        /// 题型
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 试卷id
        /// </summary>
        //public int PaperId { get; set; }
        /// <summary>
        /// 题型Id
        /// </summary>
        public int TopicId { get; set; }
        //public bool IsDel { get; set; }
        //public string BasicTopicId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        //public int? Ord { get; set; }

        //public virtual PeUserTestPaper Paper { get; set; }
        //public virtual PeTopic Topic { get; set; }
        //public virtual ICollection<PeUserTestPaperQuestions> PeUserTestPaperQuestions { get; set; }
    }
}
