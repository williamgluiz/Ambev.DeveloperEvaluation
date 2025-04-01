using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{

    /// <summary>
    /// Represents a sale in the system.
    /// </summary>
    public class Sale : BaseEntity
    {
        /// <summary>
        /// Sale number.
        /// </summary>
        public string SaleNumber { get; private set; }

        /// <summary>
        /// Date when the sale occurred.
        /// </summary>
        public DateTime SaleDate { get; private set; }

        /// <summary>
        /// Identifier of the customer associated with the sale.
        /// </summary>
        public Guid CustomerId { get; private set; }

        /// <summary>
        /// Identifier of the branch where the sale was made.
        /// </summary>
        public Guid BranchId { get; private set; }

        /// <summary>
        /// Total amount of the sale.
        /// </summary>
        public decimal TotalAmount { get; private set; }

        /// <summary>
        /// Indicates if the sale has been cancelled.
        /// </summary>
        public bool IsCancelled { get; private set; }

        /// <summary>
        /// List of items associated with the sale.
        /// </summary>
        public List<SaleItem> Items { get; private set; } = new List<SaleItem>();

        /// <summary>
        /// Initializes a new instance of the Sale class with the specified details.
        /// </summary>
        /// <remarks>
        /// This constructor sets the initial values for a sale, including the sale number, 
        /// date, customer identifier, branch identifier, and marks the sale as not cancelled by default.
        /// </remarks>
        /// <param name="saleNumber">The unique number identifying the sale.</param>
        /// <param name="date">The date the sale occurred.</param>
        /// <param name="customerId">The identifier of the customer associated with the sale.</param>
        /// <param name="branchId">The identifier of the branch where the sale was made.</param>
        public Sale(string saleNumber, DateTime date, Guid customerId, Guid branchId)
        {
            SaleNumber = saleNumber;
            SaleDate = date;
            CustomerId = customerId;
            BranchId = branchId;
            IsCancelled = false;
        }

        public Sale()
        {
            
        }

        /// <summary>
        /// Updates the sale's attributes.
        /// </summary>
        /// <remarks>
        /// This method allows updating the sale's details, such as the customer identifier, 
        /// branch identifier, sale date, items, total amount, and cancellation status. 
        /// It is designed to ensure encapsulation and maintain consistency across updates.
        /// </remarks>
        /// <param name="customerId">The identifier of the customer associated with the sale.</param>
        /// <param name="branchId">The identifier of the branch where the sale was made.</param>
        /// <param name="items">The updated list of sale items.</param>
        /// <param name="totalAmount">The total amount of the sale.</param>
        /// <param name="isCancelled">Indicates whether the sale is cancelled.</param>
        public void UpdateSale(Guid customerId, Guid branchId, List<SaleItem> items, decimal totalAmount, bool isCancelled)
        {
            CustomerId = customerId;
            BranchId = branchId;
            Items = items; 
            TotalAmount = totalAmount;
            IsCancelled = isCancelled;
            CalculateTotal();
        }

        /// <summary>
        /// Adds a new item to the sale and recalculates the total amount.
        /// </summary>
        /// <remarks>
        /// This method updates the list of items in the sale by adding the specified item 
        /// and ensures the total sale amount is recalculated accordingly.
        /// </remarks>
        /// <param name="item">The sale item to be added to the sale.</param>
        public void AddItem(SaleItem item)
        {
            Items.Add(item);
            CalculateTotal();
        }

        /// <summary>
        /// Recalculates the total amount of the sale based on the items in the sale.
        /// </summary>
        /// <remarks>
        /// This method calculates the total by summing up the total amounts of all 
        /// items currently added to the sale.
        /// </remarks>
        public void CalculateTotal()
        {
            TotalAmount = Items.Sum(item => item.TotalAmount);
        }

        /// <summary>
        /// Marks the sale as cancelled.
        /// </summary>
        /// <remarks>
        /// This method updates the sale's cancellation status to indicate that 
        /// the sale is no longer active or valid.
        /// </remarks>
        public void Cancel()
        {
            IsCancelled = true;
        }
    }
}