using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class PePaperOutputTaskAddDto
    {
        [Display(Name = "任务名称")]
        //[Required(ErrorMessage = "{0}这个字段是必填的")]
        //[MaxLength(100, ErrorMessage = "{0}的最大长度不可以超过{1}")]
        public string Name { get; set; }
        [Display(Name = "试卷标题")]
        //[Required(ErrorMessage = "{0}这个字段是必填的")]
        //[MaxLength(100, ErrorMessage = "{0}的最大长度不可以超过{1}")]
        public string Option1 { get; set; }
        [Display(Name = "副标题")]
        //[Required(ErrorMessage = "{0}这个字段是必填的")]
        [MaxLength(100, ErrorMessage = "{0}的最大长度不可以超过{1}")]
        public string Option2 { get; set; }

    }
}
