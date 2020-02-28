using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeConfig
    {
        public string PropertyName { get; set; }
        public string PropertyTag { get; set; }
        public string PropertyValue { get; set; }
        public bool Readyonly { get; set; }
        public bool? IsSystem { get; set; }
        public string Ord { get; set; }
        public string InputType { get; set; }
        public string InputPattern { get; set; }
        public string InputTip { get; set; }
        public string InputErrorTip { get; set; }
    }
}
