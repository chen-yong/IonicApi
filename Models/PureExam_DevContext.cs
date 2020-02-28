using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IonicApi.Models
{
    public partial class PureExam_DevContext : DbContext
    {
        public PureExam_DevContext()
        {
        }

        public PureExam_DevContext(DbContextOptions<PureExam_DevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<PeAdvancedJudgeCriterion> PeAdvancedJudgeCriterion { get; set; }
        public virtual DbSet<PeBasicTopic> PeBasicTopic { get; set; }
        public virtual DbSet<PeCampus> PeCampus { get; set; }
        public virtual DbSet<PeCompiler> PeCompiler { get; set; }
        public virtual DbSet<PeConfig> PeConfig { get; set; }
        public virtual DbSet<PeCourse> PeCourse { get; set; }
        public virtual DbSet<PeCourseResource> PeCourseResource { get; set; }
        public virtual DbSet<PeCourseScaffold> PeCourseScaffold { get; set; }
        public virtual DbSet<PeCourseStudent> PeCourseStudent { get; set; }
        public virtual DbSet<PeCourseware> PeCourseware { get; set; }
        public virtual DbSet<PeDrawPlot> PeDrawPlot { get; set; }
        public virtual DbSet<PeDrawPlotCata> PeDrawPlotCata { get; set; }
        public virtual DbSet<PeDrawPlotOfBundle> PeDrawPlotOfBundle { get; set; }
        public virtual DbSet<PeDrawPlotOfBundleItem> PeDrawPlotOfBundleItem { get; set; }
        public virtual DbSet<PeDrawPlotOfKnowledge> PeDrawPlotOfKnowledge { get; set; }
        public virtual DbSet<PeDrawPlotOfKnowledgeKnowledge> PeDrawPlotOfKnowledgeKnowledge { get; set; }
        public virtual DbSet<PeDrawPlotOfKnowledgeQuestionDifficulty> PeDrawPlotOfKnowledgeQuestionDifficulty { get; set; }
        public virtual DbSet<PeDrawPlotOfKnowledgeTopic> PeDrawPlotOfKnowledgeTopic { get; set; }
        public virtual DbSet<PeDrawPlotOfTestPaper> PeDrawPlotOfTestPaper { get; set; }
        public virtual DbSet<PeDrawPlotOfTestPaperItem> PeDrawPlotOfTestPaperItem { get; set; }
        public virtual DbSet<PeDrawPlotShared> PeDrawPlotShared { get; set; }
        public virtual DbSet<PeIpplot> PeIpplot { get; set; }
        public virtual DbSet<PeJudgePlot> PeJudgePlot { get; set; }
        public virtual DbSet<PeKnowledge> PeKnowledge { get; set; }
        public virtual DbSet<PeKnowledgeBase> PeKnowledgeBase { get; set; }
        public virtual DbSet<PeKnowledgeBaseShared> PeKnowledgeBaseShared { get; set; }
        public virtual DbSet<PeLab> PeLab { get; set; }
        public virtual DbSet<PeLabCategory> PeLabCategory { get; set; }
        public virtual DbSet<PeLabCategoryBasicTopic> PeLabCategoryBasicTopic { get; set; }
        public virtual DbSet<PeLabShared> PeLabShared { get; set; }
        public virtual DbSet<PeMenu> PeMenu { get; set; }
        public virtual DbSet<PeMessage> PeMessage { get; set; }
        public virtual DbSet<PeMessageAttach> PeMessageAttach { get; set; }
        public virtual DbSet<PeMessageReceive> PeMessageReceive { get; set; }
        public virtual DbSet<PePaperOutputTask> PePaperOutputTask { get; set; }
        public virtual DbSet<PeQuestion> PeQuestion { get; set; }
        public virtual DbSet<PeQuestionDesign> PeQuestionDesign { get; set; }
        public virtual DbSet<PeQuestionDifficulty> PeQuestionDifficulty { get; set; }
        public virtual DbSet<PeQuestionKnowledge> PeQuestionKnowledge { get; set; }
        public virtual DbSet<PeQuestionMaterials> PeQuestionMaterials { get; set; }
        public virtual DbSet<PeQuestionMutualJudgeRegulation> PeQuestionMutualJudgeRegulation { get; set; }
        public virtual DbSet<PeQuestionSubQuestion> PeQuestionSubQuestion { get; set; }
        public virtual DbSet<PeResource> PeResource { get; set; }
        public virtual DbSet<PeRole> PeRole { get; set; }
        public virtual DbSet<PeRoleMenu> PeRoleMenu { get; set; }
        public virtual DbSet<PeSchool> PeSchool { get; set; }
        public virtual DbSet<PeScoreGrade> PeScoreGrade { get; set; }
        public virtual DbSet<PeStudentGroup> PeStudentGroup { get; set; }
        public virtual DbSet<PeStudentGroupItem> PeStudentGroupItem { get; set; }
        public virtual DbSet<PeSysNotice> PeSysNotice { get; set; }
        public virtual DbSet<PeTableFieldManual> PeTableFieldManual { get; set; }
        public virtual DbSet<PeTemplate> PeTemplate { get; set; }
        public virtual DbSet<PeTest> PeTest { get; set; }
        public virtual DbSet<PeTestInvigilator> PeTestInvigilator { get; set; }
        public virtual DbSet<PeTestIpplot> PeTestIpplot { get; set; }
        public virtual DbSet<PeTestJudgePro> PeTestJudgePro { get; set; }
        public virtual DbSet<PeTestJudgeProItem> PeTestJudgeProItem { get; set; }
        public virtual DbSet<PeTestMutualJudgeGroup> PeTestMutualJudgeGroup { get; set; }
        public virtual DbSet<PeTestMutualJudgeGroupItem> PeTestMutualJudgeGroupItem { get; set; }
        public virtual DbSet<PeTestMutualJudgeList> PeTestMutualJudgeList { get; set; }
        public virtual DbSet<PeTestRoom> PeTestRoom { get; set; }
        public virtual DbSet<PeTestRoomUse> PeTestRoomUse { get; set; }
        public virtual DbSet<PeTestSession> PeTestSession { get; set; }
        public virtual DbSet<PeTopic> PeTopic { get; set; }
        public virtual DbSet<PeTopicBundleLabelText> PeTopicBundleLabelText { get; set; }
        public virtual DbSet<PeUser> PeUser { get; set; }
        public virtual DbSet<PeUserRole> PeUserRole { get; set; }
        public virtual DbSet<PeUserTest> PeUserTest { get; set; }
        public virtual DbSet<PeUserTestPaper> PeUserTestPaper { get; set; }
        public virtual DbSet<PeUserTestPaperQuestions> PeUserTestPaperQuestions { get; set; }
        public virtual DbSet<PeUserTestPaperTopic> PeUserTestPaperTopic { get; set; }
        public virtual DbSet<PeUserTestQuestion> PeUserTestQuestion { get; set; }
        public virtual DbSet<PeUserTestQuestionJudgeItem> PeUserTestQuestionJudgeItem { get; set; }
        public virtual DbSet<PeUserTestQuestionMutualJudge> PeUserTestQuestionMutualJudge { get; set; }
        public virtual DbSet<PeUserTestQuestionMutualJudgeItem> PeUserTestQuestionMutualJudgeItem { get; set; }
        public virtual DbSet<Sms> Sms { get; set; }
        public virtual DbSet<Thread> Thread { get; set; }
        public virtual DbSet<ThreadReply> ThreadReply { get; set; }
        public virtual DbSet<Tongji> Tongji { get; set; }
        public virtual DbSet<UploadedFile> UploadedFile { get; set; }
        public virtual DbSet<VMutualJudgeDetails> VMutualJudgeDetails { get; set; }
        public virtual DbSet<VUserTest> VUserTest { get; set; }

        #region UseSqlServer
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=.;Database=PureExam_Dev;Trusted_Connection=True;");
        //    }
        //} 
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>(entity =>
            {
                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EmailTo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameTo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PeAdvancedJudgeCriterion>(entity =>
            {
                entity.ToTable("PE__AdvancedJudgeCriterion");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RegexPatten)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PeAdvancedJudgeCriterion)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_PE__AdvancedJudgeCriterion_PE__Question");
            });

            modelBuilder.Entity<PeBasicTopic>(entity =>
            {
                entity.ToTable("PE__BasicTopic");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerContentType).HasMaxLength(10);

                entity.Property(e => e.JudgeClassName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JudgeViewName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ord)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionEditViewName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionExpoViewName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeCampus>(entity =>
            {
                entity.ToTable("PE__Campus");

                entity.HasIndex(e => e.Code)
                    .HasName("UQ__PE__Camp__A25C5AA7AA203F65")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolId)
                    .HasColumnName("SchoolID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PeCompiler>(entity =>
            {
                entity.ToTable("PE__Compiler");

                entity.Property(e => e.Arguments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExePath)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property00)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Property01)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Property02)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Property03)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Property04)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Property05)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeConfig>(entity =>
            {
                entity.HasKey(e => e.PropertyName);

                entity.ToTable("PE__Config");

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InputErrorTip)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InputPattern).IsUnicode(false);

                entity.Property(e => e.InputTip)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InputType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ord)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyTag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyValue)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeCourse>(entity =>
            {
                entity.ToTable("PE__Course");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Logo1).HasMaxLength(500);

                entity.Property(e => e.LogoBackgroundColor).HasMaxLength(20);

                entity.Property(e => e.LogoText).HasMaxLength(50);

                entity.Property(e => e.ModuleDiscuss)
                    .IsRequired()
                    .HasColumnName("Module_Discuss")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleExperiment)
                    .IsRequired()
                    .HasColumnName("Module_Experiment")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleHomework)
                    .IsRequired()
                    .HasColumnName("Module_Homework")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleKownledge)
                    .IsRequired()
                    .HasColumnName("Module_Kownledge")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleMutualJudge)
                    .IsRequired()
                    .HasColumnName("Module_MutualJudge")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleResource)
                    .IsRequired()
                    .HasColumnName("Module_Resource")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleSimulation)
                    .IsRequired()
                    .HasColumnName("Module_Simulation")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ord).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pkscj1).HasColumnName("PKSCJ1");

                entity.Property(e => e.Pkscj2).HasColumnName("PKSCJ2");

                entity.Property(e => e.Pkscj3).HasColumnName("PKSCJ3");

                entity.Property(e => e.Pkscj4).HasColumnName("PKSCJ4");

                entity.Property(e => e.Pkscj5).HasColumnName("PKSCJ5");

                entity.Property(e => e.Psycj).HasColumnName("PSYCJ");

                entity.Property(e => e.Pzycj).HasColumnName("PZYCJ");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.TeacherNavigation)
                    .WithMany(p => p.PeCourse)
                    .HasForeignKey(d => d.Teacher)
                    .HasConstraintName("FK_PE__Course_PE__User");
            });

            modelBuilder.Entity<PeCourseResource>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.ResourceId });

                entity.ToTable("PE__Course_Resource");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PeCourseResource)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_PE__Course_Resource_PE__Course");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.PeCourseResource)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_PE__Course_Resource_PE__Resource");
            });

            modelBuilder.Entity<PeCourseScaffold>(entity =>
            {
                entity.ToTable("PE__CourseScaffold");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.IdPath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasMaxLength(50);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PeCourseScaffold)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__CourseScaffold_PE__Course");
            });

            modelBuilder.Entity<PeCourseStudent>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.UserId });

                entity.ToTable("PE__CourseStudent");

                entity.Property(e => e.Cj).HasColumnName("CJ");

                entity.Property(e => e.Kscj1).HasColumnName("KSCJ1");

                entity.Property(e => e.Kscj2).HasColumnName("KSCJ2");

                entity.Property(e => e.Kscj3).HasColumnName("KSCJ3");

                entity.Property(e => e.Kscj4).HasColumnName("KSCJ4");

                entity.Property(e => e.Kscj5).HasColumnName("KSCJ5");

                entity.Property(e => e.Sycj).HasColumnName("SYCJ");

                entity.Property(e => e.Zycj).HasColumnName("ZYCJ");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PeCourseStudent)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_PE__CourseStudent_PE__Course");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PeCourseStudent)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__CourseStudent_PE__User");
            });

            modelBuilder.Entity<PeCourseware>(entity =>
            {
                entity.ToTable("PE__Courseware");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CoursewareType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ScaffoldId)
                    .IsRequired()
                    .HasColumnName("ScaffoldID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PeCourseware)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__Courseware_PE__Course");

                entity.HasOne(d => d.Scaffold)
                    .WithMany(p => p.PeCourseware)
                    .HasForeignKey(d => d.ScaffoldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__Courseware_PE__CourseScaffold");
            });

            modelBuilder.Entity<PeDrawPlot>(entity =>
            {
                entity.ToTable("PE__DrawPlot");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DiffPaperCount).HasMaxLength(10);

                entity.Property(e => e.Dptype)
                    .IsRequired()
                    .HasColumnName("DPType")
                    .HasMaxLength(20);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Cata)
                    .WithMany(p => p.PeDrawPlot)
                    .HasForeignKey(d => d.CataId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PE__DrawPlot_PE__DrawPlotCata");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.PeDrawPlot)
                    .HasForeignKey(d => d.LabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__DrawPlot_PE__Lab");
            });

            modelBuilder.Entity<PeDrawPlotCata>(entity =>
            {
                entity.ToTable("PE__DrawPlotCata");

                entity.Property(e => e.DbType).HasMaxLength(50);

                entity.Property(e => e.IsDel).HasColumnName("isDel");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PeDrawPlotOfBundle>(entity =>
            {
                entity.ToTable("PE__DrawPlotOfBundle");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PeDrawPlotOfBundle)
                    .HasForeignKey<PeDrawPlotOfBundle>(d => d.Id)
                    .HasConstraintName("FK_PE__DrawPlotOfBundle_PE__DrawPlot");
            });

            modelBuilder.Entity<PeDrawPlotOfBundleItem>(entity =>
            {
                entity.ToTable("PE__DrawPlotOfBundleItem");

                entity.HasOne(d => d.DrawPlot)
                    .WithMany(p => p.PeDrawPlotOfBundleItem)
                    .HasForeignKey(d => d.DrawPlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__DrawPlotOfBundleItem_PE__DrawPlotOfBundle");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.PeDrawPlotOfBundleItem)
                    .HasForeignKey(d => d.LabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestTemplate_PE__Lab");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PeDrawPlotOfBundleItem)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestTemplate_PE__Topic");
            });

            modelBuilder.Entity<PeDrawPlotOfKnowledge>(entity =>
            {
                entity.ToTable("PE__DrawPlotOfKnowledge");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PeDrawPlotOfKnowledge)
                    .HasForeignKey<PeDrawPlotOfKnowledge>(d => d.Id)
                    .HasConstraintName("FK_PE__DrawPlotOfKnowledge_PE__DrawPlot");

                entity.HasOne(d => d.KownledgeBase)
                    .WithMany(p => p.PeDrawPlotOfKnowledge)
                    .HasForeignKey(d => d.KownledgeBaseId)
                    .HasConstraintName("FK_PE__DrawPlotOfKownledge_PE__KownledgeBase");
            });

            modelBuilder.Entity<PeDrawPlotOfKnowledgeKnowledge>(entity =>
            {
                entity.HasKey(e => new { e.DrawPlotOfKownledgeId, e.KownledgeId })
                    .HasName("PK_PE__DrawPlotOfKownledge_Kownledge");

                entity.ToTable("PE__DrawPlotOfKnowledge_Knowledge");

                entity.HasOne(d => d.DrawPlotOfKownledge)
                    .WithMany(p => p.PeDrawPlotOfKnowledgeKnowledge)
                    .HasForeignKey(d => d.DrawPlotOfKownledgeId)
                    .HasConstraintName("FK_PE__DrawPlotOfKownledge_Kownledge_PE__DrawPlotOfKownledge");

                entity.HasOne(d => d.Kownledge)
                    .WithMany(p => p.PeDrawPlotOfKnowledgeKnowledge)
                    .HasForeignKey(d => d.KownledgeId)
                    .HasConstraintName("FK_PE__DrawPlotOfKownledge_Kownledge_PE__Kownledge");
            });

            modelBuilder.Entity<PeDrawPlotOfKnowledgeQuestionDifficulty>(entity =>
            {
                entity.HasKey(e => new { e.DrawPlotOfKownledgeId, e.QuestionDifficultyId })
                    .HasName("PK_PE__DrawPlotOfKownledge_QuestionDifficulty");

                entity.ToTable("PE__DrawPlotOfKnowledge_QuestionDifficulty");

                entity.HasOne(d => d.DrawPlotOfKownledge)
                    .WithMany(p => p.PeDrawPlotOfKnowledgeQuestionDifficulty)
                    .HasForeignKey(d => d.DrawPlotOfKownledgeId)
                    .HasConstraintName("FK_PE__DrawPlotOfKownledge_QuestionDifficulty_PE__DrawPlotOfKownledge");

                entity.HasOne(d => d.QuestionDifficulty)
                    .WithMany(p => p.PeDrawPlotOfKnowledgeQuestionDifficulty)
                    .HasForeignKey(d => d.QuestionDifficultyId)
                    .HasConstraintName("FK_PE__DrawPlotOfKownledge_QuestionDifficulty_PE__QuestionDifficulty");
            });

            modelBuilder.Entity<PeDrawPlotOfKnowledgeTopic>(entity =>
            {
                entity.HasKey(e => new { e.DrawPlotOfKownledgeId, e.TopicId })
                    .HasName("PK_PE__DrawPlotOfKownledge_Topic");

                entity.ToTable("PE__DrawPlotOfKnowledge_Topic");

                entity.HasOne(d => d.DrawPlotOfKownledge)
                    .WithMany(p => p.PeDrawPlotOfKnowledgeTopic)
                    .HasForeignKey(d => d.DrawPlotOfKownledgeId)
                    .HasConstraintName("FK_PE__DrawPlotOfKownledge_Topic_PE__DrawPlotOfKownledge");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PeDrawPlotOfKnowledgeTopic)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_PE__DrawPlotOfKownledge_Topic_PE__Topic");
            });

            modelBuilder.Entity<PeDrawPlotOfTestPaper>(entity =>
            {
                entity.ToTable("PE__DrawPlotOfTestPaper");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PeDrawPlotOfTestPaper)
                    .HasForeignKey<PeDrawPlotOfTestPaper>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__DrawPlotOfTestPaper_PE__DrawPlot");
            });

            modelBuilder.Entity<PeDrawPlotOfTestPaperItem>(entity =>
            {
                entity.ToTable("PE__DrawPlotOfTestPaperItem");

                entity.HasOne(d => d.DrawPlotOfTestPaper)
                    .WithMany(p => p.PeDrawPlotOfTestPaperItem)
                    .HasForeignKey(d => d.DrawPlotOfTestPaperId)
                    .HasConstraintName("FK_PE__DrawPlotOfTestPaperItem_PE__DrawPlotOfTestPaper");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PeDrawPlotOfTestPaperItem)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_PE__DrawPlotOfTestPaperItem_PE__Question");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PeDrawPlotOfTestPaperItem)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_PE__DrawPlotOfTestPaperItem_PE__Topic");
            });

            modelBuilder.Entity<PeDrawPlotShared>(entity =>
            {
                entity.HasKey(e => new { e.Dpid, e.UserId });

                entity.ToTable("PE__DrawPlotShared");

                entity.Property(e => e.Dpid).HasColumnName("DPId");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.PeDrawPlotShared)
                    .HasForeignKey(d => d.Dpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__DrawPlotShared_PE__DrawPlot");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PeDrawPlotShared)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__DrawPlotShared_PE__User");
            });

            modelBuilder.Entity<PeIpplot>(entity =>
            {
                entity.ToTable("PE__IPPlot");

                entity.Property(e => e.Item).IsRequired();
            });

            modelBuilder.Entity<PeJudgePlot>(entity =>
            {
                entity.ToTable("PE__JudgePlot");

                entity.Property(e => e.Compiler)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PeKnowledge>(entity =>
            {
                entity.ToTable("PE__Knowledge");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Base)
                    .WithMany(p => p.PeKnowledge)
                    .HasForeignKey(d => d.BaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__Kownledge_PE__LabCategory");
            });

            modelBuilder.Entity<PeKnowledgeBase>(entity =>
            {
                entity.ToTable("PE__KnowledgeBase");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.KnowledgeBaseCode).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.PeKnowledgeBase)
                    .HasForeignKey(d => d.CreateUserId)
                    .HasConstraintName("FK_PE__KnowledgeBase_PE__User");
            });

            modelBuilder.Entity<PeKnowledgeBaseShared>(entity =>
            {
                entity.HasKey(e => new { e.KbId, e.UserId })
                    .HasName("PK_PE__KownledgeBaseShared");

                entity.ToTable("PE__KnowledgeBaseShared");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("题目权限：R（读）W（修改）C（增加）D（删除）");

                entity.HasOne(d => d.Kb)
                    .WithMany(p => p.PeKnowledgeBaseShared)
                    .HasForeignKey(d => d.KbId)
                    .HasConstraintName("FK_PE__KownledgeBaseShared_PE__KownledgeBase");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PeKnowledgeBaseShared)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__KownledgeBaseShared_PE__User");
            });

            modelBuilder.Entity<PeLab>(entity =>
            {
                entity.ToTable("PE__Lab");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.KownledgeBaseName).HasMaxLength(100);

                entity.Property(e => e.LabCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ord).HasMaxLength(10);

                entity.Property(e => e.OriginalLabFile).HasMaxLength(500);

                entity.Property(e => e.Shared).HasComment("0 不共享， 1 全部共享，2选择共享");

                entity.Property(e => e.Status).HasComment("0调试 1发布 9停用 10删除");

                entity.HasOne(d => d.CompilerNavigation)
                    .WithMany(p => p.PeLab)
                    .HasForeignKey(d => d.Compiler)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PE__Lab_PE__Compiler");

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.PeLab)
                    .HasForeignKey(d => d.CreateUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_test_Lab_pub_plam_User");

                entity.HasOne(d => d.LabCategory)
                    .WithMany(p => p.PeLab)
                    .HasForeignKey(d => d.LabCategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PE__Lab_PE__LabCategory");
            });

            modelBuilder.Entity<PeLabCategory>(entity =>
            {
                entity.ToTable("PE__LabCategory");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PeLabCategoryBasicTopic>(entity =>
            {
                entity.HasKey(e => new { e.LabCategoryId, e.BasicTopicId });

                entity.ToTable("PE__LabCategory_BasicTopic");

                entity.Property(e => e.BasicTopicId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BasicTopic)
                    .WithMany(p => p.PeLabCategoryBasicTopic)
                    .HasForeignKey(d => d.BasicTopicId)
                    .HasConstraintName("FK_PE__LabCategory_BasicTopic_PE__BasicTopic");

                entity.HasOne(d => d.LabCategory)
                    .WithMany(p => p.PeLabCategoryBasicTopic)
                    .HasForeignKey(d => d.LabCategoryId)
                    .HasConstraintName("FK_PE__LabCategory_BasicTopic_PE__LabCategory");
            });

            modelBuilder.Entity<PeLabShared>(entity =>
            {
                entity.HasKey(e => new { e.LabId, e.UserId });

                entity.ToTable("PE__LabShared");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("题目权限：R（读）W（修改）C（增加）D（删除）");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.PeLabShared)
                    .HasForeignKey(d => d.LabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__LabShared_PE__Lab");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PeLabShared)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__LabShared_PE__User");
            });

            modelBuilder.Entity<PeMenu>(entity =>
            {
                entity.ToTable("PE__Menu");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Group)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Icon01)
                    .HasColumnName("Icon_01")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Icon02)
                    .HasColumnName("Icon_02")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('javascript:;')");
            });

            modelBuilder.Entity<PeMessage>(entity =>
            {
                entity.ToTable("PE__Message");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.SenderNavigation)
                    .WithMany(p => p.PeMessage)
                    .HasForeignKey(d => d.Sender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__Message_PE__User");
            });

            modelBuilder.Entity<PeMessageAttach>(entity =>
            {
                entity.ToTable("PE__MessageAttach");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Size).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.PeMessageAttach)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_PE__MessageAttach_PE__Message");
            });

            modelBuilder.Entity<PeMessageReceive>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.Receiver });

                entity.ToTable("PE__MessageReceive");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.PeMessageReceive)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_PE__MessageReceive_PE__Message");

                entity.HasOne(d => d.ReceiverNavigation)
                    .WithMany(p => p.PeMessageReceive)
                    .HasForeignKey(d => d.Receiver)
                    .HasConstraintName("FK_PE__MessageReceive_PE__User");
            });

            modelBuilder.Entity<PePaperOutputTask>(entity =>
            {
                entity.ToTable("PE__PaperOutputTask");

                entity.Property(e => e.CreateTempDir)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Option1).HasColumnType("text");

                entity.Property(e => e.Option2).HasColumnType("text");

                entity.Property(e => e.Option3).HasColumnType("text");

                entity.Property(e => e.Option4).HasColumnType("text");

                entity.Property(e => e.Option5).HasColumnType("text");

                entity.Property(e => e.Range)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.PePaperOutputTask)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PE__PaperOutputTask_PE__Test");
            });

            modelBuilder.Entity<PeQuestion>(entity =>
            {
                entity.ToTable("PE__Question");

                entity.Property(e => e.Analysis).HasComment("解题分析");

                entity.Property(e => e.AnswerContentType).HasMaxLength(10);

                entity.Property(e => e.DesignAnswerMode).HasComment("0 文本框，1 附件上传 2 两者都有");

                entity.Property(e => e.DifferentiationDegree)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FillBlankAnswerOrderCasually).HasColumnName("FillBlank_AnswerOrderCasually");

                entity.Property(e => e.JudgeReferDir).HasMaxLength(500);

                entity.Property(e => e.Knowledge)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionFace).IsRequired();

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((2))")
                    .HasComment("0 调试 1 发布 2禁用");

                entity.HasOne(d => d.DifficultyNavigation)
                    .WithMany(p => p.PeQuestion)
                    .HasForeignKey(d => d.Difficulty)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PE__Question_PE__QuestionDifficulty");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.PeQuestion)
                    .HasForeignKey(d => d.LabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_test_Question_test_Lab");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PeQuestion)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_test_Question_test_Topic");
            });

            modelBuilder.Entity<PeQuestionDesign>(entity =>
            {
                entity.ToTable("PE__Question_Design");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PeQuestionDesign)
                    .HasForeignKey<PeQuestionDesign>(d => d.Id)
                    .HasConstraintName("FK_test_Question_Design_test_Question");
            });

            modelBuilder.Entity<PeQuestionDifficulty>(entity =>
            {
                entity.ToTable("PE__QuestionDifficulty");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PeQuestionKnowledge>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.KnowledgeId });

                entity.ToTable("PE__Question_Knowledge");

                entity.Property(e => e.KnowledgeCode).HasMaxLength(255);

                entity.HasOne(d => d.Knowledge)
                    .WithMany(p => p.PeQuestionKnowledge)
                    .HasForeignKey(d => d.KnowledgeId)
                    .HasConstraintName("FK_PE__Question_Knowledge_PE__Knowledge");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PeQuestionKnowledge)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_PE__Question_Knowledge_PE__Question");
            });

            modelBuilder.Entity<PeQuestionMaterials>(entity =>
            {
                entity.ToTable("PE__Question_Materials");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PeQuestionMaterials)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PE__Question_Materials_PE__Question");
            });

            modelBuilder.Entity<PeQuestionMutualJudgeRegulation>(entity =>
            {
                entity.ToTable("PE__QuestionMutualJudgeRegulation");

                entity.Property(e => e.Contents).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Ord).HasMaxLength(20);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PeQuestionMutualJudgeRegulation)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_PE__QuestionMutualJudgeRegulation_PE__Question");
            });

            modelBuilder.Entity<PeQuestionSubQuestion>(entity =>
            {
                entity.ToTable("PE__Question_SubQuestion");

                entity.Property(e => e.BasicTopicId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FillBlankAnswerOrderCasually)
                    .HasColumnName("FillBlank_AnswerOrderCasually")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuestionFace).IsRequired();

                entity.HasOne(d => d.BasicTopic)
                    .WithMany(p => p.PeQuestionSubQuestion)
                    .HasForeignKey(d => d.BasicTopicId)
                    .HasConstraintName("FK_PE__Question_SubQuestion_PE__BasicTopic");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PeQuestionSubQuestion)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_PE__Question_SubQuestion_PE__Question");
            });

            modelBuilder.Entity<PeResource>(entity =>
            {
                entity.ToTable("PE__Resource");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileIcon)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeRole>(entity =>
            {
                entity.ToTable("PE__Role");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReadOnly).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PeRoleMenu>(entity =>
            {
                entity.ToTable("PE__RoleMenu");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.PeRoleMenu)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_PE__RoleMenu_PE__Menu");

                entity.HasOne(d => d.Rold)
                    .WithMany(p => p.PeRoleMenu)
                    .HasForeignKey(d => d.RoldId)
                    .HasConstraintName("FK_PE__RoleMenu_PE__RoleMenu");
            });

            modelBuilder.Entity<PeSchool>(entity =>
            {
                entity.ToTable("PE__School");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Addr).HasMaxLength(500);

                entity.Property(e => e.Banner).HasMaxLength(500);

                entity.Property(e => e.ContactEmail).HasMaxLength(30);

                entity.Property(e => e.ContactName).HasMaxLength(10);

                entity.Property(e => e.ContactOfficeTel).HasMaxLength(20);

                entity.Property(e => e.ContactPhone).HasMaxLength(20);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Logo1).HasMaxLength(500);

                entity.Property(e => e.Logo2).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Zipcode).HasMaxLength(10);
            });

            modelBuilder.Entity<PeScoreGrade>(entity =>
            {
                entity.ToTable("PE__ScoreGrade");

                entity.Property(e => e.Id).HasMaxLength(20);

                entity.Property(e => e.Jx1).HasColumnName("JX1");

                entity.Property(e => e.Jx2).HasColumnName("JX2");

                entity.Property(e => e.Lebel)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PeStudentGroup>(entity =>
            {
                entity.ToTable("PE__StudentGroup");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property00)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property01)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property02)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property03)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property04)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property05)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property06)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property07)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property08)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property09)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.PeStudentGroup)
                    .HasForeignKey(d => d.CreateUserId)
                    .HasConstraintName("FK_PE__Group_PE__User");
            });

            modelBuilder.Entity<PeStudentGroupItem>(entity =>
            {
                entity.ToTable("PE__StudentGroupItem");

                entity.Property(e => e.Property00)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property01)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property02)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property03)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property04)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property05)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property06)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property07)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property08)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property09)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PeStudentGroupItem)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__User_Group_PE__Group");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PeStudentGroupItem)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserGroup_PE__User");
            });

            modelBuilder.Entity<PeSysNotice>(entity =>
            {
                entity.ToTable("PE__SysNotice");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SysContent)
                    .IsRequired()
                    .HasColumnName("Sys_Content");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Type).HasComment("0系统公告，1课程公告");

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.PeSysNotice)
                    .HasForeignKey(d => d.CreateUserId)
                    .HasConstraintName("FK_PE__SysNotice_PE__User");
            });

            modelBuilder.Entity<PeTableFieldManual>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.FieldName });

                entity.ToTable("PE__TableFieldManual");

                entity.HasIndex(e => new { e.TableName, e.FieldName })
                    .HasName("i_tfm");

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeTemplate>(entity =>
            {
                entity.ToTable("PE__Template");

                entity.Property(e => e.EndTime1).HasColumnName("EndTime_1");

                entity.Property(e => e.EndTime10).HasColumnName("EndTime_10");

                entity.Property(e => e.EndTime2).HasColumnName("EndTime_2");

                entity.Property(e => e.EndTime3).HasColumnName("EndTime_3");

                entity.Property(e => e.EndTime4).HasColumnName("EndTime_4");

                entity.Property(e => e.EndTime5).HasColumnName("EndTime_5");

                entity.Property(e => e.EndTime6).HasColumnName("EndTime_6");

                entity.Property(e => e.EndTime7).HasColumnName("EndTime_7");

                entity.Property(e => e.EndTime8).HasColumnName("EndTime_8");

                entity.Property(e => e.EndTime9).HasColumnName("EndTime_9");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime1).HasColumnName("StartTime_1");

                entity.Property(e => e.StartTime10).HasColumnName("StartTime_10");

                entity.Property(e => e.StartTime2).HasColumnName("StartTime_2");

                entity.Property(e => e.StartTime3).HasColumnName("StartTime_3");

                entity.Property(e => e.StartTime4).HasColumnName("StartTime_4");

                entity.Property(e => e.StartTime5).HasColumnName("StartTime_5");

                entity.Property(e => e.StartTime6).HasColumnName("StartTime_6");

                entity.Property(e => e.StartTime7).HasColumnName("StartTime_7");

                entity.Property(e => e.StartTime8).HasColumnName("StartTime_8");

                entity.Property(e => e.StartTime9).HasColumnName("StartTime_9");
            });

            modelBuilder.Entity<PeTest>(entity =>
            {
                entity.ToTable("PE__Test");

                entity.Property(e => e.AutoSubmitOnTimeLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DelayEndTime).HasColumnType("datetime");

                entity.Property(e => e.EnableClientJudge).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ForbiddenCopy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForbiddenMouseRightMenu).HasDefaultValueSql("((0))");

                entity.Property(e => e.IpallowAccessCheck).HasColumnName("IPAllowAccessCheck");

                entity.Property(e => e.KeyVisible).HasDefaultValueSql("((0))");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Mode)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1考试2练习3作业4实验");

                entity.Property(e => e.MutualJudgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID")
                    .HasMaxLength(50);

                entity.Property(e => e.Ord).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeMutualJudgeGroupingPublish).HasColumnType("datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PeTest)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_PE__Test_PE__Course");

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.PeTest)
                    .HasForeignKey(d => d.CreateUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_test_Test_pub_plam_User");

                entity.HasOne(d => d.DrawPlot)
                    .WithMany(p => p.PeTest)
                    .HasForeignKey(d => d.DrawPlotId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PE__Test_PE__DrawPlot");

                entity.HasOne(d => d.TestTemplate)
                    .WithMany(p => p.PeTest)
                    .HasForeignKey(d => d.TestTemplateId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PE__Test_PE__Template");
            });

            modelBuilder.Entity<PeTestInvigilator>(entity =>
            {
                entity.ToTable("PE__TestInvigilator");

                entity.Property(e => e.TestRoomName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimePeriod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.PeTestInvigilator)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TSR_Teacher_PE__User");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.PeTestInvigilator)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_PE__TestInvigilator_PE__Test");

                entity.HasOne(d => d.TestRoom)
                    .WithMany(p => p.PeTestInvigilator)
                    .HasForeignKey(d => d.TestRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestInvigilator_PE__TestRoom");

                entity.HasOne(d => d.TestSession)
                    .WithMany(p => p.PeTestInvigilator)
                    .HasForeignKey(d => d.TestSessionId)
                    .HasConstraintName("FK_PE__TestInvigilator_PE__TestSession");
            });

            modelBuilder.Entity<PeTestIpplot>(entity =>
            {
                entity.ToTable("PE__TestIPPlot");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(50);

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.PeTestIpplot)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_PE__TestIPPlot_PE__Test");
            });

            modelBuilder.Entity<PeTestJudgePro>(entity =>
            {
                entity.ToTable("PE__TestJudgePro");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.PeTestJudgePro)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestJudgePro_PE__Test");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PeTestJudgePro)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestJudgePro_PE__User");
            });

            modelBuilder.Entity<PeTestJudgeProItem>(entity =>
            {
                entity.ToTable("PE__TestJudgeProItem");

                entity.Property(e => e.TopicIdList).HasMaxLength(50);
            });

            modelBuilder.Entity<PeTestMutualJudgeGroup>(entity =>
            {
                entity.ToTable("PE__TestMutualJudgeGroup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.PeTestMutualJudgeGroup)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestMutualJudgeGroup_PE__Test");
            });

            modelBuilder.Entity<PeTestMutualJudgeGroupItem>(entity =>
            {
                entity.HasKey(e => new { e.MutualJudgeGroupId, e.UserTestId })
                    .HasName("PK_PE__UserTestMutualJudgeGroupItem");

                entity.ToTable("PE__TestMutualJudgeGroupItem");

                entity.HasOne(d => d.MutualJudgeGroup)
                    .WithMany(p => p.PeTestMutualJudgeGroupItem)
                    .HasForeignKey(d => d.MutualJudgeGroupId)
                    .HasConstraintName("FK_PE__UserTestMutualJudgeGroupItem_PE__UserTestMutualJudgeGroup");

                entity.HasOne(d => d.UserTest)
                    .WithMany(p => p.PeTestMutualJudgeGroupItem)
                    .HasForeignKey(d => d.UserTestId)
                    .HasConstraintName("FK_PE__UserTestMutualJudgeGroupItem_PE__UserTest");
            });

            modelBuilder.Entity<PeTestMutualJudgeList>(entity =>
            {
                entity.ToTable("PE__TestMutualJudgeList");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.JudgeStudenName).HasMaxLength(50);

                entity.Property(e => e.TimeJudged).HasColumnType("datetime");

                entity.Property(e => e.UserTestUserName).HasMaxLength(50);

                entity.HasOne(d => d.JudgeStudent)
                    .WithMany(p => p.PeTestMutualJudgeList)
                    .HasForeignKey(d => d.JudgeStudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestMutualJudgeList_PE__User");

                entity.HasOne(d => d.UserTest)
                    .WithMany(p => p.PeTestMutualJudgeList)
                    .HasForeignKey(d => d.UserTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestMutualJudgeList_PE__UserTest");
            });

            modelBuilder.Entity<PeTestRoom>(entity =>
            {
                entity.ToTable("PE__TestRoom");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Property00)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property01)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property02)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property03)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property04)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolId)
                    .HasColumnName("SchoolID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.PeTestRoom)
                    .HasForeignKey(d => d.CampusId)
                    .HasConstraintName("FK_PE__TestRoom_PE__Campus");
            });

            modelBuilder.Entity<PeTestRoomUse>(entity =>
            {
                entity.HasKey(e => new { e.TestId, e.TestRoomId })
                    .HasName("PK_PE__TestSessionRoom_1");

                entity.ToTable("PE__TestRoomUse");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.PeTestRoomUse)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestSessionRoom_PE__Test");

                entity.HasOne(d => d.TestRoom)
                    .WithMany(p => p.PeTestRoomUse)
                    .HasForeignKey(d => d.TestRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__TestSessionRoom_PE__TestRoom");
            });

            modelBuilder.Entity<PeTestSession>(entity =>
            {
                entity.ToTable("PE__TestSession");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.PeTestSession)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PE__TestSession_PE__Test");
            });

            modelBuilder.Entity<PeTopic>(entity =>
            {
                entity.ToTable("PE__Topic");

                entity.Property(e => e.BasicTopicId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID")
                    .HasMaxLength(50);

                entity.Property(e => e.Ord)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDetection).HasMaxLength(50);

                entity.Property(e => e.WorkDirName).HasMaxLength(20);

                entity.HasOne(d => d.BasicTopic)
                    .WithMany(p => p.PeTopic)
                    .HasForeignKey(d => d.BasicTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_test_Topic_test_BasicTopic");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.PeTopic)
                    .HasForeignKey(d => d.LabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_test_Topic_test_Lab");
            });

            modelBuilder.Entity<PeTopicBundleLabelText>(entity =>
            {
                entity.ToTable("PE__TopicBundleLabelText");

                entity.Property(e => e.LabelText).HasMaxLength(50);

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PeTopicBundleLabelText)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_PE__TopicBundleLabelText_PE__Topic");
            });

            modelBuilder.Entity<PeUser>(entity =>
            {
                entity.ToTable("PE__User");

                entity.HasIndex(e => e.Email)
                    .HasName("UN_PE__User_Email")
                    .IsUnique()
                    .HasFilter("([Email] IS NOT NULL)");

                entity.HasIndex(e => e.Mobile)
                    .HasName("UN_PE__User_Mobile")
                    .IsUnique()
                    .HasFilter("([Mobile] IS NOT NULL)");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_User")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Avatar)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Introduction)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Property00)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property01)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property02)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property03)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property04)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property05)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("QQ");

                entity.Property(e => e.Property06)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property07)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property08)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Property09)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RealName).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.SchoolId).HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdentity00)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("老师");

                entity.Property(e => e.UserIdentity01)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("学生");

                entity.Property(e => e.UserIdentity02)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdentity03)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<PeUserRole>(entity =>
            {
                entity.ToTable("PE__UserRole");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PeUserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserRole_PE__Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PeUserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserRole_PE__UserRole");
            });

            modelBuilder.Entity<PeUserTest>(entity =>
            {
                entity.ToTable("PE__UserTest");

                entity.HasIndex(e => new { e.TestId, e.UserId })
                    .HasName("IX_PE__UserTest")
                    .IsUnique();

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrawTime).HasColumnType("datetime");

                entity.Property(e => e.IsSubmitDelay).HasDefaultValueSql("((0))");

                entity.Property(e => e.JudgeReport).HasColumnType("text");

                entity.Property(e => e.LogonIp)
                    .HasColumnName("LogonIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogonTime).HasColumnType("datetime");

                entity.Property(e => e.Property00)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property01)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property02)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property03)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property04)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property05)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property06)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property07)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property08)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property09)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreAlter).HasComment("修改后的分数");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitTime).HasColumnType("datetime");

                entity.Property(e => e.UserTestNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTestType).HasMaxLength(20);

                entity.Property(e => e.UserTrueName).HasMaxLength(50);

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.PeUserTest)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTest_PE__Test");

                entity.HasOne(d => d.TestRoom)
                    .WithMany(p => p.PeUserTest)
                    .HasForeignKey(d => d.TestRoomId)
                    .HasConstraintName("FK_PE__UserTest_PE__TestRoom");

                entity.HasOne(d => d.TestSession)
                    .WithMany(p => p.PeUserTest)
                    .HasForeignKey(d => d.TestSessionId)
                    .HasConstraintName("FK_PE__UserTest_PE__TestSession");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PeUserTest)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTest_PE__User");
            });

            modelBuilder.Entity<PeUserTestPaper>(entity =>
            {
                entity.ToTable("PE__UserTestPaper");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("createUserId");

                entity.Property(e => e.DrawplotId).HasColumnName("drawplotId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.PeUserTestPaper)
                    .HasForeignKey(d => d.CreateUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestPaper_PE__User");

                entity.HasOne(d => d.Drawplot)
                    .WithMany(p => p.PeUserTestPaper)
                    .HasForeignKey(d => d.DrawplotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestPaper_PE__DrawPlot");
            });

            modelBuilder.Entity<PeUserTestPaperQuestions>(entity =>
            {
                entity.ToTable("PE__UserTestPaperQuestions");

                entity.Property(e => e.Ord)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaperId).HasColumnName("paperId");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.PeUserTestPaperQuestions)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestPaperQuestions_PE__UserTestPaper");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PeUserTestPaperQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestPaperQuestions_PE__Question");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PeUserTestPaperQuestions)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestPaperQuestions_PE__UserTestPaperTopic");
            });

            modelBuilder.Entity<PeUserTestPaperTopic>(entity =>
            {
                entity.ToTable("PE__UserTestPaperTopic");

                entity.Property(e => e.BasicTopicId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.PeUserTestPaperTopic)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestPaperTopic_PE__UserTestPaper");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PeUserTestPaperTopic)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestPaperTopic_PE__Topic");
            });

            modelBuilder.Entity<PeUserTestQuestion>(entity =>
            {
                entity.ToTable("PE__UserTestQuestion");

                entity.HasIndex(e => e.UserTestId)
                    .HasName("IDX_UserTestQuestion_UserTestId");

                entity.HasIndex(e => new { e.UserTestId, e.QuestionId })
                    .HasName("IX_PE__UserTestQuestion")
                    .IsUnique();

                entity.Property(e => e.AnswerContentType).HasMaxLength(10);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.Score).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PeUserTestQuestion)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_PE__UserTestQuestion _PE__Question");

                entity.HasOne(d => d.UserTest)
                    .WithMany(p => p.PeUserTestQuestion)
                    .HasForeignKey(d => d.UserTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_test_UserTestQuestion _test_UserTest");
            });

            modelBuilder.Entity<PeUserTestQuestionJudgeItem>(entity =>
            {
                entity.ToTable("PE__UserTestQuestionJudgeItem");

                entity.HasOne(d => d.QuestionMutualJudgeRegulation)
                    .WithMany(p => p.PeUserTestQuestionJudgeItem)
                    .HasForeignKey(d => d.QuestionMutualJudgeRegulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestQuestionJudgeItem_PE__QuestionMutualJudgeRegulation");

                entity.HasOne(d => d.UserTestQuestion)
                    .WithMany(p => p.PeUserTestQuestionJudgeItem)
                    .HasForeignKey(d => d.UserTestQuestionId)
                    .HasConstraintName("FK_PE__UserTestQuestionJudgeItem_PE__UserTestQuestion");
            });

            modelBuilder.Entity<PeUserTestQuestionMutualJudge>(entity =>
            {
                entity.ToTable("PE__UserTestQuestionMutualJudge");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.作业人).HasMaxLength(50);

                entity.Property(e => e.评价人).HasMaxLength(50);

                entity.HasOne(d => d.AuthorStudent)
                    .WithMany(p => p.PeUserTestQuestionMutualJudgeAuthorStudent)
                    .HasForeignKey(d => d.AuthorStudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestQuestionMutualJudge_PE__User_Author");

                entity.HasOne(d => d.JudgeStudent)
                    .WithMany(p => p.PeUserTestQuestionMutualJudgeJudgeStudent)
                    .HasForeignKey(d => d.JudgeStudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestQuestionMutualJudge_PE__User_Judge");

                entity.HasOne(d => d.UserTestQuestion)
                    .WithMany(p => p.PeUserTestQuestionMutualJudge)
                    .HasForeignKey(d => d.UserTestQuestionId)
                    .HasConstraintName("FK_PE__UserTestQuestionMutualJudge_PE__UserTestQuestion");
            });

            modelBuilder.Entity<PeUserTestQuestionMutualJudgeItem>(entity =>
            {
                entity.ToTable("PE__UserTestQuestionMutualJudgeItem");

                entity.HasOne(d => d.QuestionMutualJudgeRegulation)
                    .WithMany(p => p.PeUserTestQuestionMutualJudgeItem)
                    .HasForeignKey(d => d.QuestionMutualJudgeRegulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE__UserTestQuestionMutualJudgeItem_PE__QuestionMutualJudgeRegulation");

                entity.HasOne(d => d.UserTestQuestionMutualJudge)
                    .WithMany(p => p.PeUserTestQuestionMutualJudgeItem)
                    .HasForeignKey(d => d.UserTestQuestionMutualJudgeId)
                    .HasConstraintName("FK_PE__UserTestQuestionMutualJudgeItem_PE__UserTestQuestionMutualJudge");
            });

            modelBuilder.Entity<Sms>(entity =>
            {
                entity.ToTable("SMS");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MobileTo)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Thread>(entity =>
            {
                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.创建时间).HasColumnType("datetime");

                entity.Property(e => e.创建用户id).HasColumnName("创建用户ID");

                entity.Property(e => e.发帖ip)
                    .HasColumnName("发帖IP")
                    .HasMaxLength(50);

                entity.Property(e => e.审核备注).HasMaxLength(500);

                entity.Property(e => e.审核时间).HasColumnType("datetime");

                entity.Property(e => e.审核用户id).HasColumnName("审核用户ID");

                entity.Property(e => e.审核用户姓名).HasMaxLength(20);

                entity.Property(e => e.审核结果).HasMaxLength(10);

                entity.Property(e => e.标题)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.置精时间).HasColumnType("datetime");

                entity.Property(e => e.置精理由).HasMaxLength(500);

                entity.Property(e => e.置精用户id).HasColumnName("置精用户ID");

                entity.Property(e => e.置精用户姓名).HasMaxLength(20);

                entity.Property(e => e.置顶时间).HasColumnType("datetime");

                entity.Property(e => e.课程id).HasColumnName("课程ID");

                entity.HasOne(d => d.创建用户)
                    .WithMany(p => p.Thread)
                    .HasForeignKey(d => d.创建用户id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Thread_PE__User");

                entity.HasOne(d => d.课程)
                    .WithMany(p => p.Thread)
                    .HasForeignKey(d => d.课程id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Thread_PE__Course");
            });

            modelBuilder.Entity<ThreadReply>(entity =>
            {
                entity.Property(e => e.内容).IsRequired();

                entity.Property(e => e.创建时间).HasColumnType("datetime");

                entity.Property(e => e.创建用户id).HasColumnName("创建用户ID");

                entity.Property(e => e.审核备注).HasMaxLength(500);

                entity.Property(e => e.审核时间).HasColumnType("datetime");

                entity.Property(e => e.审核用户id).HasColumnName("审核用户ID");

                entity.Property(e => e.审核用户姓名).HasMaxLength(20);

                entity.Property(e => e.审核结果).HasMaxLength(10);

                entity.Property(e => e.引用id).HasColumnName("引用ID");

                entity.Property(e => e.置精时间).HasColumnType("datetime");

                entity.Property(e => e.置精理由).HasMaxLength(500);

                entity.Property(e => e.置精用户id).HasColumnName("置精用户ID");

                entity.Property(e => e.置精用户姓名).HasMaxLength(20);

                entity.Property(e => e.讨论主题id).HasColumnName("讨论主题ID");

                entity.HasOne(d => d.创建用户)
                    .WithMany(p => p.ThreadReply)
                    .HasForeignKey(d => d.创建用户id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThreadReply_PE__User");

                entity.HasOne(d => d.讨论主题)
                    .WithMany(p => p.ThreadReply)
                    .HasForeignKey(d => d.讨论主题id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThreadReply_Thread");
            });

            modelBuilder.Entity<Tongji>(entity =>
            {
                entity.Property(e => e.学校id)
                    .HasColumnName("学校ID")
                    .HasMaxLength(50);

                entity.Property(e => e.学校名称).HasMaxLength(50);

                entity.Property(e => e.更新时间).HasColumnType("datetime");
            });

            modelBuilder.Entity<UploadedFile>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.AbsolutePath).HasMaxLength(500);

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExtensionName).HasMaxLength(20);

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PreviewCachedPath).HasMaxLength(500);

                entity.Property(e => e.SavedFileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(500);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.VirtualPath).HasMaxLength(500);
            });

            modelBuilder.Entity<VMutualJudgeDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_MutualJudgeDetails");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.Contents).HasMaxLength(500);

                entity.Property(e => e.JudgeStudenName).HasMaxLength(50);

                entity.Property(e => e.QuestionFace).IsRequired();

                entity.Property(e => e.UserTestUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<VUserTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_UserTest");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrawTime).HasColumnType("datetime");

                entity.Property(e => e.LogonIp)
                    .HasColumnName("LogonIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogonTime).HasColumnType("datetime");

                entity.Property(e => e.RoomAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomAddrId)
                    .HasColumnName("RoomAddrID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserTestNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTrueName).HasMaxLength(50);

                entity.Property(e => e.任课老师)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.场次名称)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.学院)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.座位号)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.校区)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.考试地点)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.考试时间)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.阅卷时间)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
