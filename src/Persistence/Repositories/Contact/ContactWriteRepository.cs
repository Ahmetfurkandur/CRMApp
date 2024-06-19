using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ContactWriteRepository : ReadRepository<Contact>, IContactReadRepository
    {
        public ContactWriteRepository(CrmAppDbContext context) : base(context)
        { }
    }

}
