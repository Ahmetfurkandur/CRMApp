using Application.Repositories;

namespace Application.Features.Contact.Commands.UpdateContactCommands
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommandRequest, UpdateContactCommandResponse>
    {
        readonly IContactReadRepository _readRepository;
        readonly IContactWriteRepository _writeRepository;

        public UpdateContactCommandHandler(IContactWriteRepository writeRepository, IContactReadRepository readRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
        }

        public async Task<UpdateContactCommandResponse> Handle(UpdateContactCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Contact contact = await _readRepository.GetByIdAsync(request.Id);
            contact.ContactName = request.ContactName;
            contact.PhoneNumber = request.PhoneNumber;
            contact.Email = request.Email;
            contact.WebsiteUrl = request.WebsiteUrl;
            contact.Address = request.Address;
            contact.City = request.City;
            contact.ZipCode = request.ZipCode;
            contact.Country = request.Country;
            contact.CustomerId = request.CustomerId;
            contact.PotentialCustomerId = request.PotentialCustomerId;
            await _writeRepository.SaveAsync(cancellationToken);

            return new();
        }
    }
}
