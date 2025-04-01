namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.DeleteProduct
{
    /// <summary>
    /// API response model for deleting a Product
    /// </summary>
    public class DeleteProductResponse
    {
        /// <summary>
        /// Indicates whether the deletion was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// A message providing additional information about the operation
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
