using System;
using System.ComponentModel.DataAnnotations;

namespace IonicApi.Dtos
{
    public class AdminEditDto
    {
        [Display(Name = "用户名")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        [MaxLength(20, ErrorMessage = "{0}的最大长度不可以超过{1}")]
        public string UserName { get; set; }
        public string UserNo { get; set; } ///学号
        public string Sex { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public string Property05 { get; set; }
    }
}
