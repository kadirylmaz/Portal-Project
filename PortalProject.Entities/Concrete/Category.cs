using PortalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }

        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }
    }
}
