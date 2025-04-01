namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.DeleteSaleItem
{
    /// <summary>
    /// API response model for deleting a sale item
    /// </summary>
    public class DeleteSaleItemResponse
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
