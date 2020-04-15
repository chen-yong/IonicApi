using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    /// <summary>
    /// 抽题策略
    /// </summary>
    public class DrawPlotOptions
    {
        /// <summary>
        /// 策略Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 策略名称
        /// </summary>
        public string Name { get; set; }
    }
}
