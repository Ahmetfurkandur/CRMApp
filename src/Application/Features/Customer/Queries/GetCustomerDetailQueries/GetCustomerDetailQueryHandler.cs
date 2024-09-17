using Application.Common.Dtos;
using Application.Common.Interfaces.Repositories.Customer;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Customer.Queries.GetCustomerDetailQueries
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQueryRequest, GetCustomerDetailQueryResponse>
    {
        readonly ICustomerReadRepository _repository;
        readonly IMapper _mapper;

        public GetCustomerDetailQueryHandler(ICustomerReadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCustomerDetailQueryResponse> Handle(GetCustomerDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var customerDetail = _repository.GetAll()
                .Include(customer => customer.Contacts)
                 .Where(customer => customer.Id == request.Id)
                 .Select(customer => new CustomerDetailDto
                 {
                     Id = customer.Id,
                     FirstName = customer.FirstName,
                     LastName = customer.LastName,
                     Role = customer.Role,
                     Company = customer.Company,
                     Contacts = customer.Contacts.Select(contact => new ContactDto
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
                 .SingleOrDefault();
            var response = _mapper.Map<GetCustomerDetailQueryResponse>(customerDetail);
            return response;
        }
    }
}
