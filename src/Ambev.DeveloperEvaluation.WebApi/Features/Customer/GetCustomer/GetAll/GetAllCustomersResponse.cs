namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetAll
{
    /// <summary>
    /// API response model for retrieving all customers
    /// </summary>
    public class GetAllCustomersResponse
    {
        /// <summary>
        /// The total count of customers available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// The list of customers retrieved
        /// </summary>
        public List<CustomerSummaryResponseModel> Customers { get; set; } = new();
    }

    /// <summary>
    /// Represents the summary details of a customer in the response
    /// </summary>
    public class CustomerSummaryResponseModel
    {
        /// <summary>
        /// The unique identifier of the customer
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the customer
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// External identity for referencing in other domains
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Denormalized description of the customer
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
