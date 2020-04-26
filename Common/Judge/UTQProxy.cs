using IonicApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Common.Judge
{
    public class UTQProxy
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public double TotoalScore { get; set; }
        public string Answer { get; set; }
        public string AnswerExt { get; set; }

        public string TestNID { get; set; }
        public string StudentName { get; set; }
        public double? Score { get; set; }

        public QProxy Question { get; set; }

        public List<UploadedFile> AnswerExtObj
        {
            get
            {
                List<UploadedFile> retlist = new List<UploadedFile>();
                if (AnswerExt != null)
                {
                    if (AnswerExt.StartsWith("~/"))
                    {
                        UploadedFile ret = new UploadedFile();
                        ret.VirtualPath = AnswerExt;
                        ret.Url = AnswerExt;
                        ret.OriginalFileName = Path.GetFileName(AnswerExt);
                        ret.ExtensionName = Path.GetExtension(AnswerExt);
                        ret.CanPreview = FileCanPreview(ret.OriginalFileName);
                        retlist.Add(ret);
                    }
                    else if (AnswerExt.StartsWith("{"))
                    {
                        retlist.Add(JsonConvert.DeserializeObject<UploadedFile>(AnswerExt));
                    }
                    else if (AnswerExt.StartsWith("["))
                    {
                        retlist = JsonConvert.DeserializeObject<List<UploadedFile>>(AnswerExt);
                    }
                }
                return retlist;
            }
        }

        public static bool FileCanPreview(string fileName)
        {
            var previewFileTypes = new List<string>
            {
                ".jpg", ".jpeg",".gif",".png",".doc",".docx",".xls",".xlsx",".ppt",".pptx",".text",".txt",".pdf",".html",".htm"
            };
            return previewFileTypes.Any(fileName.Contains);
        }
    }
    public class QProxy
    {
        public int TopicId { get; set; }
        public string AnswerKey { get; set; }
        public string AnswerKeyExt { get; set; }
        public double Score { get; set; }
        public string DefaultAnswer { get; set; }
        public int BundleRank { get; set; }
        public int Ord { get; set; }
        public string NID { get; set; }
        public string JudgeReferDir { get; set; }
        public bool FillBlank_AnswerOrderCasually { get; set; }

        public QDProxy Question_Design { get; set; }
        public TProxy Topic { get; set; }
        public LabProxy Lab { get; set; }
        public List<AdvancedJudgeCriterionProxy> AdvancedJudgeCriterionList { get; set; }
        public List<SubQProxy> SubQuestionList { get; set; }

    }

    public class QDProxy
    {
        public int CaseType { get; set; }
        public string Input1 { get; set; }
        public string Input2 { get; set; }
        public string Input3 { get; set; }
        public string Input4 { get; set; }
        public string Input5 { get; set; }
        public string Input6 { get; set; }
        public string Input7 { get; set; }
        public string Input8 { get; set; }
        public string Input9 { get; set; }
        public string Output1 { get; set; }
        public string Output2 { get; set; }
        public string Output3 { get; set; }
        public string Output4 { get; set; }
        public string Output5 { get; set; }
        public string Output6 { get; set; }
        public string Output7 { get; set; }
        public string Output8 { get; set; }
        public string Output9 { get; set; }
    }

    public class TProxy
    {
        public string Name { get; set; }
    }

    public class LabProxy
    {
        public string NID { get; set; }
        public PeCompiler Compiler { get; set; }
    }

    public class AdvancedJudgeCriterionProxy
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public string RegexPatten { get; set; }

        public double Score { get; set; }

        public string Memo { get; set; }
    }

    public class SubQProxy
    {
        public string BasicTopicId { get; set; }
        public string AnswerKey { get; set; }
        public double Score { get; set; }
        public bool FillBlank_AnswerOrderCasually { get; set; }
    }
}
