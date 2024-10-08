﻿using Application.Common.Interfaces.Repositories.Contact;
using AutoMapper;
using MediatR;

namespace Application.Features.Contact.Commands.AddContactCommands
{
    public class AddContactCommandHandler : IRequestHandler<AddContactCommandRequest, AddContactCommandResponse>
    {
        readonly IContactWriteRepository _repository;
        readonly IMapper _mapper;

        public AddContactCommandHandler(IContactWriteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AddContactCommandResponse> Handle(AddContactCommandRequest request, CancellationToken cancellationToken)
        {
            var contact = _mapper.Map<Domain.Entities.Contact>(request);
            await _repository.AddAsync(contact);
            await _repository.SaveAsync(cancellationToken);
            return new();
        }
    }
}
