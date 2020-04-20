using System;
using System.ComponentModel.DataAnnotations;

namespace IonicApi.Dtos
{
    public class TestEditDto
    {
        //public string Nid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        [MaxLength(100, ErrorMessage = "{0}的最大长度不可以超过{1}")]
        public string Name { get; set; }
        /// <summary>
        /// 类型：1考试 2练习 3作业 4实验
        /// </summary>
        [Display(Name = "类型")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        public int Mode { get; set; }
        /// <summary>
        /// 开启
        /// </summary>
        public bool IsOpen { get; set; }
        /// <summary>
        /// 限时完成
        /// </summary>
        public int TimeLimit { get; set; }
        /// <summary>
        /// 尝试次数
        /// </summary>
        public int RetryTimes { get; set; }
        /// <summary>
        ///  作业说明
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 创建者Id
        /// </summary>
        [Display(Name = "创建者Id")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        public int CreateUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        //public bool IsDel { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [Display(Name = "开始时间")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 截止时间
        /// </summary>
        [Display(Name = "结束时间")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        public DateTime? EndTime { get; set; }
        public int? RestTime { get; set; }
        public int? LunchTime { get; set; }
        /// <summary>
        /// 禁止复制题目
        /// </summary>
        public bool? ForbiddenCopy { get; set; }
        /// <summary>
        /// 禁止右键
        /// </summary>
        public bool? ForbiddenMouseRightMenu { get; set; }
        /// <summary>
        /// 开启学生端阅卷
        /// </summary>
        public bool? EnableClientJudge { get; set; }
        /// <summary>
        /// 学生端阅卷后标准答案可见
        /// </summary>
        public bool? KeyVisible { get; set; }
        public bool? AutoSubmitOnTimeLimit { get; set; }
        /// <summary>
        /// 策略Id
        /// </summary>
        [Display(Name = "策略Id")]
        //[Required(ErrorMessage = "{0}这个字段是必填的")]
        public int? DrawPlotId { get; set; }
        public int? TestTemplateId { get; set; }
        /// <summary>
        /// 课程ID
        /// </summary>
        [Display(Name = "课程Id")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        public int? CourseId { get; set; }
        /// <summary>
        /// 作业互评
        /// </summary>
        public bool? EnableMutualJudge { get; set; }
        public DateTime? MutualJudgeEndTime { get; set; }
        public bool? IsMutualJudgeGroupingPublished { get; set; }
        public DateTime? TimeMutualJudgeGroupingPublish { get; set; }
        public int? MutualJudgeGroupingSize { get; set; }
        /// <summary>
        /// 总分
        /// </summary>
        [Display(Name = "总分")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        public double? SetScore { get; set; }
        /// <summary>
        /// 查卷时标准答案可见
        /// </summary>
        public bool ViewOneWithAnswerKey { get; set; }
        public int? Ord { get; set; }
        /// <summary>
        /// 成绩展示:1展示，2不展示
        /// </summary>
        [Display(Name = "成绩展示")]
        //[Required(ErrorMessage = "{0}这个字段是必填的")]
        public int? ScoreAppear { get; set; }
        /// <summary>
        /// 补交截止
        /// </summary>
        public DateTime? DelayEndTime { get; set; }
        /// <summary>
        /// 补交得分比例
        /// </summary>
        public double? DelayPercentOfScore { get; set; }
        public bool IpallowAccessCheck { get; set; }
    }
}
