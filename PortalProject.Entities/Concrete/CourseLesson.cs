using PortalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class CourseLesson:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<CourseAction> CourseActions { get; set; }
    }
}
