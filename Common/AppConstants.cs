using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Common
{
    /// <summary>
    /// 常量参数
    /// </summary>
    public static partial class AppConstants
    {
        public const string OpenofficeStartArgs = "-headless -nologo -norestore -invisible -nofirststartwizard";


        public const string UserPasswordPlot = "Ciphertext"; //Ciphertext|Cleartext

        /// <summary>
        /// PE__User UserIdentity03
        /// </summary>
        public static class UserType
        {
            public const string Student = "1";
            public const string Teacher = "2";
            public const string Admin = "0";
        }
        /// <summary>
        /// PE__User UserIdentity01
        /// </summary>
        public static class UserStatus
        {
            public const string Normal = "1";
            public const string Deleted = "0";
            public const string Forbiden = "2";
        }

        public static class DrawPlotType
        {
            public const string Bundle = "Bundle";
            public const string Knowledge = "Knowledge";
            public const string TestPaper = "TestPaper";
        }

        public static class TestMode
        {
            public const int Test = 1;
            public const int Exercise = 2;
            public const int Homework = 3;
            public const int Experiment = 4;
        }


        public static class InternalRole
        {
            public const string SystemAdmin = "系统管理员";
            public const string SchoolAdmin = "学校管理员";
        }

        public static class DesignAnswerMode
        {
            public const int HtmlEditor = 0;
            public const int UploadFile = 1;
            public const int ALL = 2;
        }

        public const string DesKey = "deskey1a";
    }
}
