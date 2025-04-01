using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a Product available for sale.
    /// </summary>
    public class Product : BaseEntity
    {

        /// <summary>
        /// Name of the Product.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// External identity for referencing in other domains.
        /// </summary>
        public string ExternalId { get; private set; }

        /// <summary>
        /// Description of the Product.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Price of the Product.
        /// </summary>
        public decimal Price { get; private set; }

        public Product(string name, string externalId, string description, decimal price)
        {
            Name = name;
            ExternalId = externalId;
            Description = description;
            Price = price;
        }

        /// <summary>
        /// Updates the Product's details.
        /// </summary>
        /// <remarks>
        /// This method allows updating the Product's attributes: Name, Description, and Price.
        /// It is intended to be used for modifications to an existing Product instance,
        /// maintaining encapsulation and consistency.
        /// </remarks>
        /// <param name="name">The new name for the Product.</param>
        /// <param name="description">The updated description of the Product.</param>
        /// <param name="price">The modified price of the Product.</param>
        public void UpdateProduct(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
