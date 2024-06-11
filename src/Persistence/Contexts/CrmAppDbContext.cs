using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Domain.Entities.Task;

namespace Persistence.Contexts
{
    public class CrmAppDbContext : DbContext
    {
        public CrmAppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<PotentialCustomer> PotentialCustomers { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
