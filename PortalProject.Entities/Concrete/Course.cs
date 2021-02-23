using PortalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class Course:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPublished { get; set; }
        public virtual ICollection<CourseLesson> CourseLessons { get; set; }
        public virtual ICollection<CourseAction> CourseActions { get; set; }
    }
}
