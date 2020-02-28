using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeJudgePlot
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int TopicId { get; set; }
        public int Percentage { get; set; }
        public string Compiler { get; set; }
    }
}
