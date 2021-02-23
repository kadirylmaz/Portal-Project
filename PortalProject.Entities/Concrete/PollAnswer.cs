using PortalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class PollAnswer:BaseEntity
    {
        public int PollId { get; set; }
        public Poll Poll { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public virtual ICollection<PollVotingRecord> PollVotingRecords { get; set; }
    }
}
