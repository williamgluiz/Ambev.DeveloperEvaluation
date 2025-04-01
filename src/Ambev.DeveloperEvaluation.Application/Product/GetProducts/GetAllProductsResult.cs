namespace Ambev.DeveloperEvaluation.Application.Product.GetProducts
{
    /// <summary>
    /// Response returned after successfully retrieving all Products.
    /// </summary>
    /// <remarks>
    /// This response contains a list of Products, 
    /// where each Product includes its ID, name, ExternalId, price, and description.
    /// </remarks>
    public class GetAllProductsResult
    {
        /// <summary>
        /// The total count of Products available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the list of Products.
        /// </summary>
        public IEnumerable<ProductResult> Products { get; set; } = new List<ProductResult>();
    }

    /// <summary>
    /// Represents details of a single Product in the GetAllProductsResponse.
    /// </summary>
    public class ProductResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the Product.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the Product.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ExternalId of the Product.
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
