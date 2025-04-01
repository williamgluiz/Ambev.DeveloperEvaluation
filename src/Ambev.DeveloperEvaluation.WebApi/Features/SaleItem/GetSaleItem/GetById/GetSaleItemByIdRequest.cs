namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetById
{
    /// <summary>
    /// Request model for retrieving a sale item by its ID
    /// </summary>
    public class GetSaleItemByIdRequest
    {
        /// <summary>
        /// The unique identifier of the sale item to retrieve
        /// </summary>
        public Guid Id { get; set; }
    }
}
