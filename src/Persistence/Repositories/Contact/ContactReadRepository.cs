﻿using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
    {
        public ContactReadRepository(CrmAppDbContext context) : base(context)
        { }
    }
}
