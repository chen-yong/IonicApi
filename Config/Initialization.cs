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
      
    }
    public static class TestMode
    {
        public const int Test = 1;
        public const int Exercise = 2;
        public const int Homework = 3;
        public const int Experiment = 4;
    }
}
