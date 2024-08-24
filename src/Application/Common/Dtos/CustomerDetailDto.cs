using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Dtos
{
    public class CustomerDetailDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public List<ContactDto> Contacts { get; set; }
        //public ICollection<Deal> Deals { get; set; }
        //public ICollection<Domain.Entities.Task> Tasks { get; set; }
    }
}
