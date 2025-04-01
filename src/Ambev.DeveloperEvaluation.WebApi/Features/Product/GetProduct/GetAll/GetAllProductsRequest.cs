namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetAll
{
    /// <summary>
    /// Request model for retrieving all Products
    /// </summary>
    public class GetAllProductsRequest
    {
        /// <summary>
        /// Optional search term to filter Products
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// The number of records to skip (for pagination)
        /// </summary>
        public int Skip { get; set; } = 0;

        /// <summary>
        /// The number of records to take (for pagination)
        /// </summary>
        public int Take { get; set; } = 10;
    }
}
