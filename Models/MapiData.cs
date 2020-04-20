using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Modes
{
    public class MapiData
    {
        public MapiData()
        {
            items = new List<object>();
        }
        /// <summary>
        /// 返回码：0正确，11参数错误，12服务器错误，13认证令牌（authtoken）失效，99未知错误
        /// </summary>
        public int retcode { get; set; }
        /// <summary>
        /// 用户登录令牌
        /// </summary>
        public string authtoken { get; set; }
        /// <summary>
        /// 请求返回数据
        /// </summary>
        public object info { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int pagecount { get; set; }
        /// <summary>
        /// 数据总条数
        /// </summary>
        public int recordcount { get; set; }
        /// <summary>
        /// 是否是第一页
        /// </summary>
        public bool isfirst { get; set; }
        /// <summary>
        /// 是否有下一页
        /// </summary>
        public bool hasnext { get; set; }
        public List<object> items { get; set; }
        public string debug { get; set; }
        public int id { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? datetime { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string message { get; set; }
    }
}
