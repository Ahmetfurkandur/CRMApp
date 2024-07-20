namespace Application.Features.Customer.Queries.GetCustomerDetailQueries
{
    public record GetCustomerDetailQueryResponse
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Role { get; init; }
        public string Company { get; init; }
        public string ContactName { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
        public string WebsiteUrl { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string ZipCode { get; init; }
        public string Country { get; init; }
    }
}