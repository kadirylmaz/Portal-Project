using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class ArticleCategory
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
