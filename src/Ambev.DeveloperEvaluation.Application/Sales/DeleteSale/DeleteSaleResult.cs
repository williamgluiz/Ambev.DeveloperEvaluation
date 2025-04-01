namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale
{
    /// <summary>
    /// Response returned after deleting a sale.
    /// </summary>
    /// <remarks>
    /// This response indicates whether the deletion was successful and provides
    /// a message with additional details.
    /// </remarks>
    public class DeleteSaleResult
    {
        /// <summary>
        /// Indicates if the deletion was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides additional details about the deletion result.
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
