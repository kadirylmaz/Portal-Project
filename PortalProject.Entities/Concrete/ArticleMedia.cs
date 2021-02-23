using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class ArticleMedia
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
