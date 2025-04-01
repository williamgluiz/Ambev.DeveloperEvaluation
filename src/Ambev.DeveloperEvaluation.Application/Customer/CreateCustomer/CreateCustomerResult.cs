namespace Ambev.DeveloperEvaluation.Application.Customer.CreateCustomer
{
    /// <summary>
    /// Response returned after successfully creating a new customer.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created customer,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class CreateCustomerResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created customer.
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
