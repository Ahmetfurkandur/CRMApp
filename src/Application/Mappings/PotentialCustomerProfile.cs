using Application.Common.Dtos;
using Application.Features.PotentialCustomer.Commands.AddPotentialCustomerCommands;
using Application.Features.PotentialCustomer.Queries.GetPotentialCustomerDetailQueries;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class PotentialCustomerProfile : Profile
    {
        public PotentialCustomerProfile()
        {
            CreateMap<PotentialCustomer, AddPotentialCustomerCommandRequest>().ReverseMap();
            CreateMap<PotentialCustomerDetailDto, GetPotentialCustomerDetailQueryResponse>().ReverseMap();
        }
    }
}
