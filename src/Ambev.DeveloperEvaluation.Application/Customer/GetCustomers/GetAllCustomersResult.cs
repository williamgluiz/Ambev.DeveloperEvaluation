namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomers
{
    /// <summary>
    /// Response returned after successfully retrieving all customers.
    /// </summary>
    /// <remarks>
    /// This response contains a list of customers, 
    /// where each customer includes their ID, name, external ID, and description.
    /// </remarks>
    public class GetAllCustomersResult
    {
        /// <summary>
        /// The total count of customers available
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// Gets or sets the list of customers.
        /// </summary>
        public IEnumerable<CustomerResult> Customers { get; set; } = new List<CustomerResult>();
    }

    /// <summary>
    /// Represents details of a single customer in the GetAllCustomersResult.
    /// </summary>
    public class CustomerResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the customer.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the external ID of the customer.
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the customer.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
