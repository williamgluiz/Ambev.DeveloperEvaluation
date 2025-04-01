using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomerById
{
    /// <summary>
    /// Response returned after successfully retrieving a customer by their unique identifier.
    /// </summary>
    /// <remarks>
    /// This response contains the details of the customer retrieved, 
    /// including their name, external ID, and description.
    /// </remarks>
    public class GetCustomerByIdResult
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
