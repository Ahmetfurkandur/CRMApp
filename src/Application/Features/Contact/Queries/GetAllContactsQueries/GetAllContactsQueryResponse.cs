using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Contact.Queries.GetAllContactsQueries
{
    public record GetAllContactsQueryResponse(object Data, int TotalCount);
    
}
