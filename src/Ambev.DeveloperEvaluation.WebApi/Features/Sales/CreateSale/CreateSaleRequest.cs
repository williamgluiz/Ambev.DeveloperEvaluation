namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// Represents a request to create a new sale in the system.
    /// </summary>
    public class CreateSaleRequest
    {
        /// <summary>
        /// Gets or sets the sale number. Must be unique.
        /// </summary>
        public string SaleNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date when the sale was made.
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Gets or sets the customer associated with the sale.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the branch where the sale was made.
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// Gets or sets the list of items included in the sale.
        /// </summary>
        public List<SaleItemRequestModel> Items { get; set; } = new();

        /// <summary>
        /// Gets or sets the total amount of the sale.
        /// </summary>
        //public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }
        public CreateSaleRequest()
        {
            
        }
    }

    /// <summary>
    /// Represents the details of an item in the sale request.
    /// </summary>
    public class SaleItemRequestModel
    {
        /// <summary>
        /// Gets or sets the Product identifier.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the SaleItem being sold.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the SaleItem.
        /// </summary>
        public decimal UnitPrice { get; set; }

        public SaleItemRequestModel()
        {
            
        }

    }
}
