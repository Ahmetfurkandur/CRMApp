using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Contact.Commands.DeleteContactCommands
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommandRequest, DeleteContactCommandResponse>
    {
        readonly IContactWriteRepository _repository;

        public DeleteContactCommandHandler(IContactWriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<DeleteContactCommandResponse> Handle(DeleteContactCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
            await _repository.SaveAsync(cancellationToken);

            return new();
        }
    }
}
