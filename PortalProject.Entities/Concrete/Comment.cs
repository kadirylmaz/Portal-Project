using PortalProject.Core.Entities;
using PortalProject.Entities.Common;
using PortalProject.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class Comment:BaseEntity
    {
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public CommentStatus CommentStatus { get; set; } = CommentStatus.Pending;
        public string CommentText { get; set; }
        public string CommenterEmail { get; set; }
        public string CommenterName { get; set; }
        public int? ParentId { get; set; } //Yoruma cevap yazma
        public Comment Parent { get; set; }
        public IList<Comment> Replies { get; protected set; } = new List<Comment>();
    }
}
