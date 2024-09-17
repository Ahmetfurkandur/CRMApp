using Application.Features.Contact.Commands.AddContactCommands;
using Application.Features.Contact.Queries.GetContactsByNameQueries;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, AddContactCommandRequest>().ReverseMap();
            CreateMap<GetContactsByNameQueryResponse, Contact>().ReverseMap();
        }
    }
}
