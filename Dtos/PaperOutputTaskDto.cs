using IonicApi.Models;
using System;

namespace IonicApi.Dtos
{
    public class PaperOutputTaskDto
    {
        public int Id { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 试卷总数
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// 完成时数量
        /// </summary>
        public int FinishCount { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime? FinishTime { get; set; }
        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public string FileSize { get; set; }
        
    }
}
