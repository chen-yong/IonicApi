using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class PeUserTestPaperQuestionDto
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public int QuestionId { get; set; }
        public int PaperId { get; set; }
        public int Rank { get; set; }
        //public string Ord { get; set; }

    }
}
