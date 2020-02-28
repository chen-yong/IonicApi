using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTableFieldManual
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public string Memo { get; set; }
    }
}
