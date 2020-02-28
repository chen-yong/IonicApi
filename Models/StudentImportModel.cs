using IonicApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Models
{
    public class StudentImportModel
    {
        private string _pwd = "123456";
        /// <summary>
        /// 行号
        /// </summary>
        public string LineNo { get; set; }

        public string Pwd
        {
            get
            {
                return StringUtils.md5HashString(_pwd);
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _pwd = value;
                }
            }
        }
        /// <summary>
        /// 学号
        /// </summary>
        public string UserNo { get; set; }
        public string RealName { get; set; }
        public string Sex { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string QQ { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        public string Cls { get; set; }
        /// <summary>
        /// 教师
        /// </summary>
        public string Teacher { get; set; }
        /// <summary>
        /// 考试时间
        /// </summary>
        public string TestTime { get; set; }
        /// <summary>
        /// 考试场次
        /// </summary>
        public string Session { get; set; }
        /// <summary>
        /// 考试地点
        /// </summary>
        public string Addr { get; set; }
        /// <summary>
        /// 准考证
        /// </summary>
        public string TestNumber { get; set; }
        /// <summary>
        /// 座位
        /// </summary>
        public string Seat { get; set; }
        /// <summary>
        /// 校区
        /// </summary>
        public string Campus { get; set; }
        /// <summary>
        /// 学院， 系
        /// </summary>
        public string Faculty { get; set; }
    }
}
