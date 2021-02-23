
using PortalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Identity.Entities
{
    public class OperationClaim:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
