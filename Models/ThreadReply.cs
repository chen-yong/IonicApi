using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class ThreadReply
    {
        public int Id { get; set; }
        public int 讨论主题id { get; set; }
        public int? 引用id { get; set; }
        public string 内容 { get; set; }
        public bool 教师回复标志 { get; set; }
        public int 点赞个数 { get; set; }
        public bool 审核标志 { get; set; }
        public DateTime? 审核时间 { get; set; }
        public string 审核结果 { get; set; }
        public string 审核备注 { get; set; }
        public int? 审核用户id { get; set; }
        public string 审核用户姓名 { get; set; }
        public bool? 精华标志 { get; set; }
        public DateTime? 置精时间 { get; set; }
        public string 置精理由 { get; set; }
        public int? 置精用户id { get; set; }
        public string 置精用户姓名 { get; set; }
        public int 创建用户id { get; set; }
        public DateTime 创建时间 { get; set; }
        public bool IsDel { get; set; }

        public virtual PeUser 创建用户 { get; set; }
        public virtual Thread 讨论主题 { get; set; }
    }
}
