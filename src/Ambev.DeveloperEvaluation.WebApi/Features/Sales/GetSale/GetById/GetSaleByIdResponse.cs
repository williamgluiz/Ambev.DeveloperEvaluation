namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetById
{
    /// <summary>
    /// API response model for GetSale operation
    /// </summary>
    public class GetSaleResponse
    {
        /// <summary>
        /// The unique identifier of the sale
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The sale number
        /// </summary>
        public string SaleNumber { get; set; } = string.Empty;

        /// <summary>
        /// The date when the sale was made
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// The customer associated with the sale
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The branch where the sale was made
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// The total amount of the sale
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Indicates whether the sale is cancelled
        /// </summary>
        public bool IsCancelled { get; set; }

        /// <summary>
        /// The list of items included in the sale
        /// </summary>
        public List<SaleItemResponseModel> Items { get; set; } = new();
    }

    /// <summary>
    /// Represents the details of an item in the sale response
    /// </summary>
    public class SaleItemResponseModel
    {
        /// <summary>
        /// The unique identifier of the sale item
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The SaleItem identifier
        /// </summary>
        public Guid SaleItemId { get; set; }

        /// <summary>
        /// The quantity of the SaleItem sold
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The unit price of the SaleItem
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The discount applied to the item
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// The total amount for the item after applying the discount
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Indicates whether the item is cancelled
        /// </summary>
        public bool IsCancelled { get; set; }
    }
}
