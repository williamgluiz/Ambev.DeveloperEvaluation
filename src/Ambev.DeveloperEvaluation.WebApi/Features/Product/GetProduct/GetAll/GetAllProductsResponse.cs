namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetAll
{
    /// <summary>
    /// API response model for retrieving all Products
    /// </summary>
    public class GetAllProductsResponse
    {
        /// <summary>
        /// The total count of Products available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// The list of Products retrieved
        /// </summary>
        public List<ProductSummaryResponseModel> Products { get; set; } = new();
    }

    /// <summary>
    /// Represents the summary details of a Product in the response
    /// </summary>
    public class ProductSummaryResponseModel
    {
        /// <summary>
        /// The unique identifier of the Product
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
