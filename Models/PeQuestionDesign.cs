using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeQuestionDesign
    {
        public int Id { get; set; }
        public int CaseType { get; set; }
        public string Input1 { get; set; }
        public string Output1 { get; set; }
        public string Input2 { get; set; }
        public string Output2 { get; set; }
        public string Input3 { get; set; }
        public string Output3 { get; set; }
        public string Input4 { get; set; }
        public string Output4 { get; set; }
        public string Input5 { get; set; }
        public string Output5 { get; set; }
        public string Input6 { get; set; }
        public string Output6 { get; set; }
        public string Input7 { get; set; }
        public string Output7 { get; set; }
        public string Input8 { get; set; }
        public string Output8 { get; set; }
        public string Input9 { get; set; }
        public string Output9 { get; set; }

        public virtual PeQuestion IdNavigation { get; set; }
    }
}
