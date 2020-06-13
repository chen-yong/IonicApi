using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    /// 获取用户的对外展示的信息model
    public class MessageAddDto
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        public string Code { get; set; }
        public int Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsImportant { get; set; }
        public DateTime SendTime { get; set; }
        public bool IsDel { get; set; }
        public bool IsRecycle { get; set; }

    }
}
