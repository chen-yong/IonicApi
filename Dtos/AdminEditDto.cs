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
        [Display(Name = "密码")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "{0}的长度范围从{2}到{1}")]
        public string Password { get; set; }
        public string RealName { get; set; }
        public string UserNo { get; set; } ///学号
        public string Sex { get; set; }
        public DateTime Brithday { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserIdentity00 { get; set; }
        public string UserIdentity01 { get; set; }
        public string UserIdentity02 { get; set; }
        public string UserIdentity03 { get; set; }
        public string Zip { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public string Introduction { get; set; }
        public string Property00 { get; set; }
        public string Property01 { get; set; }
        public string Property02 { get; set; }
        public string Property03 { get; set; }
        public string Property04 { get; set; }
        public string Property05 { get; set; }
        public string Property06 { get; set; }
        public string Property07 { get; set; }
        public string Property08 { get; set; }
        public string Property09 { get; set; }
        public string SchoolId { get; set; }
        public string School { get; set; }
    }
}
