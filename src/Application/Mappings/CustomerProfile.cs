using Application.Features.Customer.Commands.AddCustomerCommands;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer,AddCustomerCommandRequest>().ReverseMap();
        }
    }
}
