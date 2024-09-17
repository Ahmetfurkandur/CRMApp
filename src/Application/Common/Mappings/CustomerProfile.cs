using Application.Common.Dtos;
using Application.Features.Customer.Commands.AddCustomerCommands;
using Application.Features.Customer.Queries.GetCustomerDetailQueries;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, AddCustomerCommandRequest>().ReverseMap();
            CreateMap<CustomerDetailDto, GetCustomerDetailQueryResponse>().ReverseMap();
        }
    }
}
