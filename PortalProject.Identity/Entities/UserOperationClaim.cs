using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Identity.Entities
{
    public class UserOperationClaim
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int OperationClaimId { get; set; }
        public OperationClaim OperationClaim { get; set; }
    }
}
