using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class UploadedFile
    {
        public string Id { get; set; }
        public string OriginalFileName { get; set; }
        public string SavedFileName { get; set; }
        public string ContentType { get; set; }
        public int ContentLength { get; set; }
        public string VirtualPath { get; set; }
        public string AbsolutePath { get; set; }
        public bool CanPreview { get; set; }
        public bool PreviewCached { get; set; }
        public string PreviewCachedPath { get; set; }
        public DateTime CreateTime { get; set; }
        public string UserId { get; set; }
        public bool IsDel { get; set; }
        public string Url { get; set; }
        public string ExtensionName { get; set; }
    }
}
