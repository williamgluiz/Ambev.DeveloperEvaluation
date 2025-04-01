namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.CreateCustomer
{
    /// <summary>
    /// Request model for creating a new customer
    /// </summary>
    public class CreateCustomerRequest
    {
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
