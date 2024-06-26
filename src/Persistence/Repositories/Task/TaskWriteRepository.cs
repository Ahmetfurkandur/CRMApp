﻿using Application.Repositories;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class TaskWriteRepository : WriteRepository<Domain.Entities.Task>, ITaskWriteRepository
    {
        public TaskWriteRepository(CrmAppDbContext context) : base(context)
        {
        }
    }
}
