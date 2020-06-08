using System;
using System.ComponentModel.DataAnnotations;

namespace IonicApi.Dtos
{
    public class PwdEditDto
    {
        [Display(Name = "密码")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "{0}的长度范围从{2}到{1}")]
        public string Password { get; set; }
    
    }
}
