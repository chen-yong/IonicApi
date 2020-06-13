using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    /// 获取用户的对外展示的信息model
    public class MessageReceiveAddDto
    {
        /// <summary>
        /// ID
        /// </summary>
        public int MessageId { get; set; }
        public int Receiver { get; set; }
        public bool IsReaded { get; set; }
        public bool IsDel { get; set; }
        public bool IsRecycle { get; set; }

    }
}
