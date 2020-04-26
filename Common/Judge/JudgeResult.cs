using System.Collections.Generic;
using System.Linq;

namespace IonicApi.Dtos
{
    public class JudgeResult
    {
        public JudgeResult()
        {
            JudgeResultItemSet = new List<JudgeResultItem>();
        }
        /// <summary>
        /// 阅卷是否成功
        /// </summary>
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public int UsetTestQuestionId { get; set; }
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public int BundleId { get; set; }
        public int Ord { get; set; }
        public int QuestionId { get; set; }

        public List<JudgeResultItem> JudgeResultItemSet { get; set; }

        public string QuestionInfo
        {
            get
            {
                return string.Format("{0}，第{1:00}套，第{2:00}题", TopicName, BundleId, Ord);
            }
        }

        public double FullScore
        {
            get
            {
                return JudgeResultItemSet.Sum(e => e.FullScore);
            }
        }

        public double GotScore
        {
            get
            {
                return JudgeResultItemSet.Sum(e => e.GotScore);
            }
        }

        public string Report
        {
            get
            {
                return QuestionInfo + "\t" + string.Format("总分 {0:0.##}", FullScore) + "\t" + string.Format("得分 {0:0.##}", GotScore) + "\r\n详细：" + ErrorMessage + "\r\n" + string.Join("\r\n", JudgeResultItemSet.ConvertAll<string>(e => e.Report));
            }
        }

    }
    public class JudgeResultItem
    {
        /// <summary>
        /// 是否正确
        /// </summary>
        public bool Right { get; set; }
        /// <summary>
        /// 知识点
        /// </summary>
        public string Knowlegde { get; set; }
        /// <summary>
        /// 反馈信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 参考答案
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 评语， 结论（正确，错误，部分正确）
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// 满分
        /// </summary>
        public double FullScore { get; set; }
        /// <summary>
        /// 实际得分
        /// </summary>
        public double GotScore { get; set; }

        public string Report
        {
            get
            {
                return "\t" + Comment + "\t" + Message + "\t" + FullScore + "\t" + GotScore;
            }
        }
    }
}
