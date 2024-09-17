using Application.Common.Interfaces.Repositories.Contact;
using MediatR;

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
