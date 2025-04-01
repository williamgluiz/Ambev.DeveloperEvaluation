namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetAll
{
    /// <summary>
    /// API response model for retrieving all sale items
    /// </summary>
    public class GetAllSaleItemsResponse
    {
        /// <summary>
        /// The total count of sale items available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// The list of sale items retrieved
        /// </summary>
        public List<SaleItemSummaryResponseModel> SaleItems { get; set; } = new();
    }

    /// <summary>
    /// Represents the summary details of a sale item in the response
    /// </summary>
    public class SaleItemSummaryResponseModel
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
