using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Config
{
    public partial class Initialization
    {
        public const bool IsEncrypt = false;
        //CustomId
        public const string CID = "NBBB201409";
        //加密方式，Softdog(D)|Net(N)|Multiple(M)|Timedog(T)
        public const string EncryptMethod = "T";
        //EncryptKey
        public const string PublicKey = "";
        public const string DogId = "";
        public const string DogKey = "";
        public const string SentinelKeyDll = "SentinelKeyW.dll";
        //连接数
        public const int Concurrent = 5000;
        public readonly static string[] BindDomain = { "dodo.hznu.edu.cn" }; //dodo.hznu.edu.cn
        public readonly static string[] BindIPAddr = { "172.31.214.208" }; //172.31.214.208

        public const string StudentFirstView = "MyCourse"; //MyCourse
        public const string StudentFirstViewMaster = "_LayoutFront.cshtml"; //_LayoutFront.cshtml
        public const bool ShowQuestionRedo = true; // true
        public const string TestNumberLabel = "准考证号"; //准考证号
        public const bool JudgeViewAnonymous = false; // false
        public const bool SingleClientLogon = false;

        public static readonly string[] OpenedLabCategory = new string[] { "程序设计类", "其他类", "OPENExam类题库" };
        public static readonly string[] OpenedCompiler = new string[] { "C编译器", "C++编译器", "Java编译器", "Python", "C#编译器" };

        public static readonly bool IsLicenseCacheEnabled = true;

        #region Users
        public static User[] S_User = new User[]{
            new User{
                Id = "S_0",
                Account = "PE_Supper0",
                Password = "CAI2014$_#OpenEx",
                Name = "超级管理员0",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "2"
            },
            new User{
                Id = "S_1",
                Account = "PE_Supper1",
                Password = "CAI2014$_#OpenEx",
                Name = "超级管理员1",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "2"
            },
            new User{
                Id = "S_2",
                Account = "PE_Supper2",
                Password = "CAI2014$_#OpenEx",
                Name = "超级管理员2",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "2"
            },
            new User{
                Id = "S_3",
                Account = "PE_Supper3",
                Password = "CAI2014$_#OpenEx",
                Name = "超级管理员3",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "2"
            },
            new User{
                Id = "S_4",
                Account = "PE_Supper4",
                Password = "CAI2014$_#OpenEx",
                Name = "超级管理员4",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "2"
            },
            new User{
                Id = "S_5",
                Account = "PE_Supper5",
                Password = "CAI2014$_#OpenEx",
                Name = "超级管理员5",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "2"
            },
            new User
            {
                Id = "S_6",
                Account = "PE_Student6",
                Password = "st2014$_#OpenEx",
                Name = "一个考生6",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "1"
            }
            ,
            new User
            {
                Id = "S_7",
                Account = "PE_Student7",
                Password = "st2014$_#OpenEx",
                Name = "一个考生7",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "1"
            }
            ,
            new User
            {
                Id = "S_8",
                Account = "PE_Student8",
                Password = "st2014$_#OpenEx",
                Name = "一个考生8",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "1"
            }
            ,
            new User
            {
                Id = "S_9",
                Account = "PE_Student9",
                Password = "st2014$_#OpenEx",
                Name = "一个考生9",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "1"
            }
            ,
            new User
            {
                Id = "S_10",
                Account = "PE_Student10",
                Password = "st2014$_#OpenEx",
                Name = "一个考生10",
                EMail = "OpenExam@qq.com",
                UserIdentity03 = "1"
            }
        }; 
        #endregion
    }
    public class User
    {
        public string Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string UserIdentity01 { get; set; }
        public string UserIdentity03 { get; set; }

    }
}
