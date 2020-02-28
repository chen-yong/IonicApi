using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Modes
{
    public class MapiData
    {
        public MapiData()
        {
            items = new List<object>();
        }
        public int retcode { get; set; }
        public string authtoken { get; set; }
        public object info { get; set; }
        public int pagecount { get; set; }
        public int recordcount { get; set; }
        public bool isfirst { get; set; }
        public bool hasnext { get; set; }
        public List<object> items { get; set; }
        public string debug { get; set; }
        public int id { get; set; }
        public DateTime? datetime { get; set; }
        public string message { get; set; }
    }
}
