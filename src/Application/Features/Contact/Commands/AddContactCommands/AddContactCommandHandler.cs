using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
