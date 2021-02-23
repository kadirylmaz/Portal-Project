using PortalProject.Core.Entities;
using PortalProject.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class Media:BaseEntity
    {
        public string Caption { get; set; }
        public int FileSize { get; set; }
        public string FileName { get; set; }
        public MediaType MediaType { get; set; }
        public virtual ICollection<ArticleMedia> ArticleMedias { get; set; }
    }
}
