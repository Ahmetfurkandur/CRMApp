using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Deal: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DealStatus DealStatus { get; set; }
        public decimal Amount { get; set; }
        public DateTime CloseDate { get; set; }
        public string Note { get; set; }
        public ICollection<string> Tags { get; set; }
        public string Owner { get; set; }
        public Guid TaskId { get; set; }
        public ICollection<Contact> Contacts { get; set; }

    }
}
