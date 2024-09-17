using MediatR;

namespace Application.Features.Contact.Commands.DeleteContactCommands
{
    public record DeleteContactCommandRequest(Guid Id):IRequest<DeleteContactCommandResponse>;
    
}
