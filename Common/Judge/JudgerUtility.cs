using IonicApi.Models;
using System;
using System.Linq;

namespace IonicApi.Common.Judge
{
    public static class JudgerUtility
    {

        internal static IJudger CreateJudgerByReflection(string p)
        {
            Type t = Type.GetType(p);
            return (IJudger)Activator.CreateInstance(t);
        }
        public static UTQProxy UTQProxy(PeUserTestQuestion utq, PeUserTest ut = null)
        {
            UTQProxy proxy = new UTQProxy();
            proxy.Id = utq.Id;
            proxy.QuestionId = utq.QuestionId;
            proxy.TotoalScore = utq.TotoalScore ?? 0;
            proxy.Answer = utq.Answer;
            proxy.AnswerExt = utq.AnswerExt;
            proxy.Question = new QProxy
            {
                TopicId = utq.Question.TopicId,
                AnswerKey = utq.Question.AnswerKey,
                Score = utq.Question.Score,
                Topic = new TProxy
                {
                    Name = utq.Question.Topic.Name
                },

                DefaultAnswer = utq.Question.DefaultAnswer,
                BundleRank = utq.Question.BundleRank,
                Ord = utq.Question.Ord ?? 0,
                NID = utq.Question.Nid,
                JudgeReferDir = utq.Question.JudgeReferDir,
                AnswerKeyExt = utq.Question.AnswerKeyExt,
                FillBlank_AnswerOrderCasually = utq.Question.FillBlankAnswerOrderCasually ?? false
            };
            if (utq.Question.PeQuestionDesign != null)
            {
                proxy.Question.Question_Design = new QDProxy
                {
                    CaseType = utq.Question.PeQuestionDesign.CaseType,
                    Input1 = utq.Question.PeQuestionDesign.Input1,
                    Input2 = utq.Question.PeQuestionDesign.Input2,
                    Input3 = utq.Question.PeQuestionDesign.Input3,
                    Input4 = utq.Question.PeQuestionDesign.Input4,
                    Input5 = utq.Question.PeQuestionDesign.Input5,
                    Input6 = utq.Question.PeQuestionDesign.Input6,
                    Input7 = utq.Question.PeQuestionDesign.Input7,
                    Input8 = utq.Question.PeQuestionDesign.Input8,
                    Input9 = utq.Question.PeQuestionDesign.Input9,
                    Output1 = utq.Question.PeQuestionDesign.Output1,
                    Output2 = utq.Question.PeQuestionDesign.Output2,
                    Output3 = utq.Question.PeQuestionDesign.Output3,
                    Output4 = utq.Question.PeQuestionDesign.Output4,
                    Output5 = utq.Question.PeQuestionDesign.Output5,
                    Output6 = utq.Question.PeQuestionDesign.Output6,
                    Output7 = utq.Question.PeQuestionDesign.Output7,
                    Output8 = utq.Question.PeQuestionDesign.Output8,
                    Output9 = utq.Question.PeQuestionDesign.Output9
                };
            }
            if (utq.Question.Lab.Compiler.HasValue)
            {

                proxy.Question.Lab = new LabProxy
                {
                    Compiler = new PeCompiler
                    {
                        ExePath = utq.Question.Lab.CompilerNavigation.ExePath,
                        Arguments = utq.Question.Lab.CompilerNavigation.Arguments,
                        Property00 = utq.Question.Lab.CompilerNavigation.Property00,
                        Property01 = utq.Question.Lab.CompilerNavigation.Property01,
                        Property02 = utq.Question.Lab.CompilerNavigation.Property02,
                        Property03 = utq.Question.Lab.CompilerNavigation.Property03,
                        Property04 = utq.Question.Lab.CompilerNavigation.Property04,
                        Property05 = utq.Question.Lab.CompilerNavigation.Property05
                    }
                };
            }
            if (utq.Question.PeAdvancedJudgeCriterion.Any())
            {
                proxy.Question.AdvancedJudgeCriterionList = utq.Question.PeAdvancedJudgeCriterion.Select(e => new AdvancedJudgeCriterionProxy
                {
                    Id = e.Id,
                    Memo = e.Memo,
                    QuestionId = e.QuestionId,
                    RegexPatten = e.RegexPatten,
                    Score = e.Score
                }).ToList();
            }

            if (utq.Question.PeQuestionSubQuestion.Any())
            {
                proxy.Question.SubQuestionList = utq.Question.PeQuestionSubQuestion.Select(e => new SubQProxy
                {
                    AnswerKey = e.AnswerKey,
                    BasicTopicId = e.BasicTopicId,
                    Score = e.Score,
                    FillBlank_AnswerOrderCasually = e.FillBlankAnswerOrderCasually ?? false
                }).ToList();
            }

            if (ut != null && (utq.Question.Topic.BasicTopicId == "OPENEXAM_INT"
                || utq.Question.Topic.BasicTopicId == "OPENEXAM_OFC"
                || utq.Question.Topic.BasicTopicId == "OPENEXAM_WIN"))
            {
                proxy.TestNID = ut.Test.Nid;
                proxy.StudentName = ut.User.UserName;
            }
            return proxy;
        }
    }
}
