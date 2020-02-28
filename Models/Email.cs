using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class Email
    {
        public int Id { get; set; }
        public string EmailTo { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string NameTo { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
