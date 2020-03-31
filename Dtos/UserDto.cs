using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserNO { get; set; }
        public string Password { get; set; }
        public string  RealName { get; set; }
        public string  Sex { get; set; }
        public DateTime Brithday { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserIdentity00 { get; set; }
        //0:删除 1：正常
        public string UserIdentity01 { get; set; }
        public string UserIdentity02 { get; set; }
        //1：学生 2.老师
        public string UserIdentity03 { get; set; }
        public string Zip { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public string Introduction { get; set; }
        public string Property00 { get; set; }
        public string Property01 { get; set; }
        //班级
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
