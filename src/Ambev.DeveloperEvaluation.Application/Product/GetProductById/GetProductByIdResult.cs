using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProductById
{
    /// <summary>
    /// Response returned after successfully retrieving a Product by its unique identifier.
    /// </summary>
    /// <remarks>
    /// This response contains the details of the Product retrieved, 
    /// including its name, ExternalId, price, and description.
    /// </remarks>
    public class GetProductByIdResult
    {
        /// <summary>
        /// The total count of Products available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the Product.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the Product.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// External identity for referencing in other domains
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price of the Product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the Product.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
