namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetAll
{
    /// <summary>
    /// API response model for GetAllSales operation
    /// </summary>
    public class GetAllSalesResponse
    {
        /// <summary>
        /// The total count of sales available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// The list of sales retrieved
        /// </summary>
        public List<SaleItemsResponseModel> Sales { get; set; } = new();
    }

    /// <summary>
    /// Represents the summary details of a sale in the response
    /// </summary>
    public class SaleItemsResponseModel
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale.
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
        /// Gets or sets the identifier of the customer who made the purchase.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the branch.
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// The total amount of the sale
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}
