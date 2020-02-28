using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class Thread
    {
        public Thread()
        {
            ThreadReply = new HashSet<ThreadReply>();
        }

        public int Id { get; set; }
        public int 课程id { get; set; }
        public string 标题 { get; set; }
        public string 内容 { get; set; }
        public bool? 教师主题标志 { get; set; }
        public bool? 教师参与标志 { get; set; }
        public int? 查看次数 { get; set; }
        public int? 点赞个数 { get; set; }
        public bool? 审核标志 { get; set; }
        public DateTime? 审核时间 { get; set; }
        public string 审核结果 { get; set; }
        public string 审核备注 { get; set; }
        public int? 审核用户id { get; set; }
        public string 审核用户姓名 { get; set; }
        public bool? 置顶标志 { get; set; }
        public DateTime? 置顶时间 { get; set; }
        public bool? 精华标志 { get; set; }
        public DateTime? 置精时间 { get; set; }
        public string 置精理由 { get; set; }
        public int? 置精用户id { get; set; }
        public string 置精用户姓名 { get; set; }
        public string 发帖ip { get; set; }
        public int? 回帖个数 { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int 创建用户id { get; set; }
        public DateTime 创建时间 { get; set; }
        public bool IsDel { get; set; }

        public virtual PeUser 创建用户 { get; set; }
        public virtual PeCourse 课程 { get; set; }
        public virtual ICollection<ThreadReply> ThreadReply { get; set; }
    }
}
