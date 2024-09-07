using Application.Common.Dtos;
using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.PotentialCustomer.Queries.GetPotentialCustomerDetailQueries
{
    public class GetPotentialCustomerDetailQueryHandler : IRequestHandler<GetPotentialCustomerDetailQueryRequest, GetPotentialCustomerDetailQueryResponse>
    {
        private readonly IPotentialCustomerReadRepository _repository;
        private readonly IMapper _mapper;

        public GetPotentialCustomerDetailQueryHandler(IPotentialCustomerReadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetPotentialCustomerDetailQueryResponse> Handle(GetPotentialCustomerDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var potentialCustomerDetail = await _repository.GetAll()
                .Include(potentialCustomer => potentialCustomer.Contacts)
                 .Where(potentialCustomer => potentialCustomer.Id == request.Id)
                 .Select(potentialCustomer => new PotentialCustomerDetailDto
                 {
                     Id = potentialCustomer.Id,
                     FirstName = potentialCustomer.FirstName,
                     LastName = potentialCustomer.LastName,
                     Role = potentialCustomer.Role,
                     Company = potentialCustomer.Company,
                     InterestedProduct = potentialCustomer.InterestedProduct,
                     LeadStatus = potentialCustomer.LeadStatus,
                     Contacts = potentialCustomer.Contacts.Select(contact => new ContactDto
                     {
                         ContactName = contact.ContactName,
                         Address = contact.Address,
                         City = contact.City,
                         Country = contact.Country,
                         Email = contact.Email,
                         PhoneNumber = contact.PhoneNumber,
                         WebsiteUrl = contact.WebsiteUrl,
                         ZipCode = contact.ZipCode
                     }).ToList()
                 })
                 .SingleOrDefaultAsync(cancellationToken);
            var response = _mapper.Map<GetPotentialCustomerDetailQueryResponse>(potentialCustomerDetail);
            return response;
        }
    }
}
