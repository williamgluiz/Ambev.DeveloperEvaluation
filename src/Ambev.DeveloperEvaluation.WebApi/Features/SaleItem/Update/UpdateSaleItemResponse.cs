namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.Update
{
    /// <summary>
    /// API response model for updating an existing sale item
    /// </summary>
    public class UpdateSaleItemResponse
    {
        /// <summary>
        /// The unique identifier of the updated sale item
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identifier of the sale this item belongs to
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Updated quantity sold of the SaleItem
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Updated unit price of the SaleItem
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Updated discount applied to the item
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Updated total amount of the item after applying the discount
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}
