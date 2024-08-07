﻿using Application.Features.Contact.Commands.AddContactCommands;
using Application.Features.Contact.Queries.GetContactsByNameQueries;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class ContactProfile:Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, AddContactCommandRequest>().ReverseMap();
            CreateMap<GetContactsByNameQueryResponse, Contact>().ReverseMap();
        }
    }
}
