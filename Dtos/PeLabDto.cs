using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    /// <summary>
    /// 题库信息
    /// </summary>
    public class PeLabDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 题库名字
        /// </summary>
        public string Name { get; set; }
        public int Shared { get; set; }

    }
}
