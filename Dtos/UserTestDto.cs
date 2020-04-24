using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    /// <summary>
    /// 作业实验批阅
    /// </summary>
    public class UserTestDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string UserTestNo { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string UserTrueName { get; set; }
        /// <summary>
        /// 登录IP 
        /// </summary>
        public string LogonIp { get; set; }
        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime? SubmitTime { get; set; }
        /// <summary>
        /// 答题数
        /// </summary>
        public int FinishQuestionCount { get; set; }
        /// <summary>
        /// 总分
        /// </summary>
        public double? TotalScore { get; set; }
        /// <summary>
        /// 得分
        /// </summary>
        public double? Score { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool? Status { get; set; }
    }
}
