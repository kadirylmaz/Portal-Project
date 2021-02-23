using PortalProject.Core.Entities;
using PortalProject.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class PollVotingRecord:BaseEntity
    {
        public int PollAnswerId { get; set; }
        public virtual PollAnswer PollAnswer { get; set; }
        public int PollId { get; set; }
        public Poll Poll { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
