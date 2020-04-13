using IonicApi.Models;
using System;

namespace IonicApi.Dtos
{
    public class PaperOutputTaskDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TestId { get; set; }
        public string Range { get; set; }
        public int TotalCount { get; set; }
        public int FinishCount { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? StartTime { get; set; }
        public bool BeCreatePdfFile { get; set; }
        public string CreateTempDir { get; set; }
        public DateTime? FinishTime { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public string FileSize { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }

        public virtual PeTest Test { get; set; }
    }
}
