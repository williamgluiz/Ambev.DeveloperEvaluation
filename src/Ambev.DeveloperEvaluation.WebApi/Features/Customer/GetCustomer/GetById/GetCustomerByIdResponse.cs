namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetById
{
    /// <summary>
    /// API response model for retrieving a customer by ID
    /// </summary>
    public class GetCustomerByIdResponse
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
