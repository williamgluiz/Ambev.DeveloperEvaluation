namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.CreateSaleItem
{
    /// <summary>
    /// Request model for creating a new sale item
    /// </summary>
    public class CreateSaleItemRequest
    {
        /// <summary>
        /// Identifier of the sale this item belongs to
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Identifier of the associated SaleItem
        /// </summary>
        public Guid SaleItemId { get; set; }

        /// <summary>
        /// Quantity sold of the SaleItem
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Unit price of the SaleItem
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}
