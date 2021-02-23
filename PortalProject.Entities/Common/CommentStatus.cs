using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.Entities.Common
{
    public enum CommentStatus
    {
        Pending = 1, //Bekliyor
        Approved = 5, //Yayınlandı
        NotApproved = 8 // Yayın kabul edilmedi
    }
}
