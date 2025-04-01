namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.UpdateProduct
{
    /// <summary>
    /// Request model for updating an existing Product
    /// </summary>
    public class UpdateProductRequest
    {
        /// <summary>
        /// The unique identifier of the Product to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The updated name of the Product
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The updated external identifier for the Product
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// The updated description of the Product
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The updated price of the Product
        /// </summary>
        public decimal Price { get; set; }
    }
}
