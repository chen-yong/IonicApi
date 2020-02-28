using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class Sms
    {
        public int Id { get; set; }
        public string MobileTo { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
