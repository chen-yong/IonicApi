using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeSchool
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo1 { get; set; }
        public string Logo2 { get; set; }
        public string Banner { get; set; }
        public string Addr { get; set; }
        public string Zipcode { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactOfficeTel { get; set; }
        public string ContactEmail { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDel { get; set; }
    }
}
