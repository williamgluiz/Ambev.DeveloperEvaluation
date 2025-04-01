namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created sale.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// (Optional) The sale number.
        /// </summary>
        public string SaleNumber { get; set; }

        /// <summary>
        /// (Optional) The date when the sale occurred.
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// (Optional) The total amount of the sale.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// (Optional) Indicates whether the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }
    }
}
