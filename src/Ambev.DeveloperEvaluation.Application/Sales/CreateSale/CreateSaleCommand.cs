using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Command for creating a new sale.
    /// </summary>
    /// <remarks>
    /// This command captures the required data for creating a sale, 
    /// including CustomerId, Quantity, and TotalPrice. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreateSaleResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreateSaleCommandValidator"/> to ensure the fields follow required rules.
    /// </remarks>
    public class CreateSaleCommand : IRequest<CreateSaleResult>
    {
        /// <summary>
        /// The unique number identifying the sale.
        /// </summary>
        public string SaleNumber { get; set; } = string.Empty;

        /// <summary>
        /// The date when the sale occurred.
        /// </summary>
        public DateTime SaleDate { get; set; }


        /// <summary>
        /// Gets or sets the identifier of the customer making the purchase.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The identifier of the branch where the sale was made.
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// The list of items included in the sale.
        /// </summary>
        public List<SaleItemCommandModel> Items { get; set; } = new();

        /// <summary>
        /// The total amount of the sale.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Indicates whether the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }

        /// <summary>
        /// Validates the command using CreateSaleCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new CreateSaleCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }

    /// <summary>
    /// Represents the details of an item in the sale command.
    /// </summary>
    public class SaleItemCommandModel
    {
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
    }
}

