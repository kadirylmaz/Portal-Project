﻿using PortalProject.Core.Entities;
using PortalProject.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Concrete
{
    public class Contact:BaseEntity
    {
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Content { get; set; }
    }
}
