namespace Ambev.DeveloperEvaluation.Application.Sales.GetSaleById
{
    /// <summary>
    /// Response returned after successfully retrieving a sale by its unique identifier.
    /// </summary>
    /// <remarks>
    /// This response contains the details of the sale retrieved, 
    /// including CustomerId, Quantity, and TotalPrice.
    /// </remarks>
    public class GetSaleByIdResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the customer who made the purchase.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The sale number
        /// </summary>
        public string SaleNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the identifier of the branch.
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the SaleItem sold.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the total price of the sale.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Indicates whether the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }

        /// <summary>
        /// The list of items included in the sale.
        /// </summary>
        public List<SaleItemResponseModel> Items { get; set; } = new();
    }

    /// <summary>
    /// Represents the details of an item in the sale command.
    /// </summary>
    public class SaleItemResponseModel
    {
        /// <summary>
        /// The unique identifier of the sale item.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The product identifier.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// The quantity of the SaleItem being sold.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The unit price of the SaleItem.
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
    }
}
