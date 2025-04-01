namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    /// <summary>
    /// Response returned after successfully updating a customer.
    /// </summary>
    /// <remarks>
    /// This response indicates whether the update was successful and provides
    /// additional details.
    /// </remarks>
    public class UpdateCustomerResult
    {
        /// <summary>
        /// Indicates if the update was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides additional details about the update result.
        /// </summary>
        public string Message { get; set; } = string.Empty;

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
