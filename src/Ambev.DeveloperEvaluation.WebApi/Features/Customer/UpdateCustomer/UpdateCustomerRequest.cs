namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.UpdateCustomer
{
    /// <summary>
    /// Request model for updating an existing customer
    /// </summary>
    public class UpdateCustomerRequest
    {
        /// <summary>
        /// The unique identifier of the customer to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The updated name of the customer
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The updated external identifier for the customer
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// The updated denormalized description of the customer
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
