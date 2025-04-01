
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale
{
    /// <summary>
    /// Request model for updating a sale
    /// </summary>
    public class UpdateSaleRequest
    {
        /// <summary>
        /// The unique identifier of the sale to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The sale number. Must be unique.
        /// </summary>
        public string SaleNumber { get; set; } = string.Empty;

        /// <summary>
        /// The date when the sale was made.
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// The customer associated with the sale.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The branch where the sale was made.
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// The list of items included in the sale.
        /// </summary>
        public List<SaleItemUpdateRequestModel> Items { get; set; } = new();

        /// <summary>
        /// The total amount of the sale.
        /// </summary>
        //public decimal TotalAmount { get; set; }

        /// <summary>
        /// Indicates whether the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }
    }

    /// <summary>
    /// Represents the details of an item in the sale update request
    /// </summary>
    public class SaleItemUpdateRequestModel
    {
        /// <summary>
        /// The unique identifier of the sale item
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The SaleItem identifier
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// The quantity of the SaleItem sold
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The unit price of the SaleItem
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}
