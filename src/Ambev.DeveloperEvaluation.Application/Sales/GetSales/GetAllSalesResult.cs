namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    /// <summary>
    /// Response returned after successfully retrieving all sales.
    /// </summary>
    /// <remarks>
    /// This response contains a list of sales, 
    /// where each sale includes its ID, CustomerId, Quantity, and TotalPrice.
    /// </remarks>
    public class GetAllSalesResult
    {
        /// <summary>
        /// The total count of sales available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the list of sales.
        /// </summary>
        public IEnumerable<SaleResult> Sales { get; set; } = new List<SaleResult>();
    }

    /// <summary>
    /// Represents details of a single sale in the GetAllSalesResponse.
    /// </summary>
    public class SaleResult
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
