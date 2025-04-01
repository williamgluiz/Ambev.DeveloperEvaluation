namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.CreateSaleItem
{
    /// <summary>
    /// API response model for creating a new sale item
    /// </summary>
    public class CreateSaleItemResponse
    {
        /// <summary>
        /// The unique identifier of the sale item
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
        /// Quantity sold of the SaleItem
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Unit price of the SaleItem
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Discount applied to the item
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Total amount of the item after applying the discount
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}
