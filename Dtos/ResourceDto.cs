using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class ResourceDto
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string FileName { get; set; }
        public string FileIcon { get; set; }
        public string Url { get; set; }
        public string FileType { get; set; }
        public double Size { get; set; }
        public bool IsDir { get; set; }
        public bool IsDel { get; set; }
        public bool IsShared { get; set; }
        public DateTime CreateTime { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
    }
}
