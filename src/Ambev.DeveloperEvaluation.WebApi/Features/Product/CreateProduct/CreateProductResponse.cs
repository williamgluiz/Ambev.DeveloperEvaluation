namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.CreateProduct
{
    /// <summary>
    /// API response model for creating a new Product
    /// </summary>
    public class CreateProductResponse
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
