namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetAll
{
    /// <summary>
    /// Request model for retrieving all customers
    /// </summary>
    public class GetAllCustomersRequest
    {
        /// <summary>
        /// Optional search term to filter customers
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// The number of records to skip (for pagination)
        /// </summary>
        public int Skip { get; set; } = 0;

        /// <summary>
        /// The number of records to take (for pagination)
        /// </summary>
        public int Take { get; set; } = 10;
    }
}
