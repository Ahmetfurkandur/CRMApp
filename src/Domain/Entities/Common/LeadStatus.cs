using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public enum LeadStatus
    {
        New,
        Open,
        InProgress,
        OpenDeal,
        UnQualified,
        AttemtedToContact,
        Connected,
        BadTiming
    }
}
