using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestIpplot
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }

        public virtual PeTest Test { get; set; }
    }
}
