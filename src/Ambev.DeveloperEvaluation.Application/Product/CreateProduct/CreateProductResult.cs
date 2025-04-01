using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Product.CreateProduct
{
    /// <summary>
    /// Response returned after successfully creating a new Product.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created Product,
    /// along with other relevant details.
    /// </remarks>
    public class CreateProductResult
    {
        /// <summary>
        /// The unique identifier of the created Product
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the Product
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// External identity for referencing in other domains
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Description of the Product
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Price of the Product
        /// </summary>
        public decimal Price { get; set; }
    }
}
