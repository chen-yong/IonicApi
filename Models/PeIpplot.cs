using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeIpplot
    {
        public int Id { get; set; }
        public string Target { get; set; }
        public string ItemGroup { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
    }
}
