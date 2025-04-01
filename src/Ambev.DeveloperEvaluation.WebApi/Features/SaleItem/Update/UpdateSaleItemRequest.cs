namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.Update
{
    /// <summary>
    /// Request model for updating an existing sale item
    /// </summary>
    public class UpdateSaleItemRequest
    {
        /// <summary>
        /// The unique identifier of the sale item to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identifier of the sale this item belongs to
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Identifier of the associated SaleItem
        /// </summary>
        public Guid SaleItemId { get; set; }

        /// <summary>
        /// Updated quantity sold of the SaleItem
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Updated unit price of the SaleItem
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}
