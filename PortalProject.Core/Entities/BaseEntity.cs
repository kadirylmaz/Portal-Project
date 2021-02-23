using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Core.Entities
{
    public abstract class BaseEntity:IEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
