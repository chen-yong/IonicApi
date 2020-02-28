using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class Tongji
    {
        public int Id { get; set; }
        public string 学校id { get; set; }
        public string 学校名称 { get; set; }
        public int? 老师数 { get; set; }
        public int? 学生数 { get; set; }
        public int? 课程数 { get; set; }
        public int? 题目数 { get; set; }
        public int? 考试数 { get; set; }
        public DateTime? 更新时间 { get; set; }
    }
}
