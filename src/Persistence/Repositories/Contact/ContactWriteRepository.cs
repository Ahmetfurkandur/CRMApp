﻿using Application.Common.Interfaces.Repositories.Contact;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
    {
        public ContactWriteRepository(CrmAppDbContext context) : base(context)
        { }
    }

}
