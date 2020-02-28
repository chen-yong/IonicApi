using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeQuestionMaterials
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public string Size { get; set; }

        public virtual PeQuestion Question { get; set; }
    }
}
