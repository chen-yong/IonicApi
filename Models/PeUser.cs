using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUser
    {
        public bool IsVaild { get { return UserIdentity01 == "1"; } }  //是否被删除，是否还存在
        public bool IsTeacher { get { return UserIdentity03 == "2"; } }  
        public string UserType { get { return IsTeacher ? "教师" : "学生"; } }
        public string SearchKey { get { return RealName + "//" + UserName; } }
        public PeUser()
        {
            PeCourse = new HashSet<PeCourse>();
            PeCourseStudent = new HashSet<PeCourseStudent>();
            PeDrawPlotShared = new HashSet<PeDrawPlotShared>();
            PeKnowledgeBase = new HashSet<PeKnowledgeBase>();
            PeKnowledgeBaseShared = new HashSet<PeKnowledgeBaseShared>();
            PeLab = new HashSet<PeLab>();
            PeLabShared = new HashSet<PeLabShared>();
            PeMessage = new HashSet<PeMessage>();
            PeMessageReceive = new HashSet<PeMessageReceive>();
            PeStudentGroup = new HashSet<PeStudentGroup>();
            PeStudentGroupItem = new HashSet<PeStudentGroupItem>();
            PeSysNotice = new HashSet<PeSysNotice>();
            PeTest = new HashSet<PeTest>();
            PeTestInvigilator = new HashSet<PeTestInvigilator>();
            PeTestJudgePro = new HashSet<PeTestJudgePro>();
            PeTestMutualJudgeList = new HashSet<PeTestMutualJudgeList>();
            PeUserRole = new HashSet<PeUserRole>();
            PeUserTest = new HashSet<PeUserTest>();
            PeUserTestPaper = new HashSet<PeUserTestPaper>();
            PeUserTestQuestionMutualJudgeAuthorStudent = new HashSet<PeUserTestQuestionMutualJudge>();
            PeUserTestQuestionMutualJudgeJudgeStudent = new HashSet<PeUserTestQuestionMutualJudge>();
            Thread = new HashSet<Thread>();
            ThreadReply = new HashSet<ThreadReply>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserNo { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string CardNo { get; set; }
        public string UserIdentity00 { get; set; }
        public string UserIdentity01 { get; set; }  //是否被软删除（禁用）
        public string UserIdentity02 { get; set; }
        public string UserIdentity03 { get; set; }  //是不是学生：1.学生；2.老师
        public string Zip { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }  //用户头像
        public string Introduction { get; set; }
        public string Property00 { get; set; }  //班级
        public string Property01 { get; set; }  //校区
        public string Property02 { get; set; }  //学院、系
        public string Property03 { get; set; }   
        public string Property04 { get; set; }
        public string Property05 { get; set; }  //QQ
        public string Property06 { get; set; }
        public string Property07 { get; set; }
        public string Property08 { get; set; }
        public string Property09 { get; set; }
        public string SchoolId { get; set; }
        public string School { get; set; }

        public virtual ICollection<PeCourse> PeCourse { get; set; }
        public virtual ICollection<PeCourseStudent> PeCourseStudent { get; set; }
        public virtual ICollection<PeDrawPlotShared> PeDrawPlotShared { get; set; }
        public virtual ICollection<PeKnowledgeBase> PeKnowledgeBase { get; set; }
        public virtual ICollection<PeKnowledgeBaseShared> PeKnowledgeBaseShared { get; set; }
        public virtual ICollection<PeLab> PeLab { get; set; }
        public virtual ICollection<PeLabShared> PeLabShared { get; set; }
        public virtual ICollection<PeMessage> PeMessage { get; set; }
        public virtual ICollection<PeMessageReceive> PeMessageReceive { get; set; }
        public virtual ICollection<PeStudentGroup> PeStudentGroup { get; set; }
        public virtual ICollection<PeStudentGroupItem> PeStudentGroupItem { get; set; }
        public virtual ICollection<PeSysNotice> PeSysNotice { get; set; }
        public virtual ICollection<PeTest> PeTest { get; set; }
        public virtual ICollection<PeTestInvigilator> PeTestInvigilator { get; set; }
        public virtual ICollection<PeTestJudgePro> PeTestJudgePro { get; set; }
        public virtual ICollection<PeTestMutualJudgeList> PeTestMutualJudgeList { get; set; }
        public virtual ICollection<PeUserRole> PeUserRole { get; set; }
        public virtual ICollection<PeUserTest> PeUserTest { get; set; }
        public virtual ICollection<PeUserTestPaper> PeUserTestPaper { get; set; }
        public virtual ICollection<PeUserTestQuestionMutualJudge> PeUserTestQuestionMutualJudgeAuthorStudent { get; set; }
        public virtual ICollection<PeUserTestQuestionMutualJudge> PeUserTestQuestionMutualJudgeJudgeStudent { get; set; }
        public virtual ICollection<Thread> Thread { get; set; }
        public virtual ICollection<ThreadReply> ThreadReply { get; set; }
    }
}
