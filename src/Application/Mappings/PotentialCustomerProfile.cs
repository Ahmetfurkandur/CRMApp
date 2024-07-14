using Application.Features.PotentialCustomer.Commands.AddPotentialCustomerCommands;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class PotentialCustomerProfile : Profile
    {
        public PotentialCustomerProfile()
        {
            CreateMap<PotentialCustomer, AddPotentialCustomerCommandRequest>().ReverseMap();
        }
    }
}
