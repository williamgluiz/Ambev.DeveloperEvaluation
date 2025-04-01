using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomers
{
    /// <summary>
    /// Query for retrieving all customers with optional filtering and pagination
    /// </summary>
    public class GetAllCustomersQuery : IRequest<GetAllCustomersResult>
    {
        /// <summary>
        /// Optional search term to filter customers
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// The number of records to skip (for pagination)
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// The number of records to take (for pagination)
        /// </summary>
        public int Take { get; set; }
    }
}
