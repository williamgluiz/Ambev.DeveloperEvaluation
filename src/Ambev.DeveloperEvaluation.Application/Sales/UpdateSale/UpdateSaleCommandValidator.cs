using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale
{
    /// <summary>
    /// Validator for the UpdateSaleCommand.
    /// </summary>
    /// <remarks>
    /// This validator ensures that the fields in the UpdateSaleCommand adhere to 
    /// the required business rules and constraints.
    /// </remarks>
    public class UpdateSaleCommandValidator : AbstractValidator<UpdateSaleCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSaleCommandValidator class.
        /// </summary>
        public UpdateSaleCommandValidator()
        {
            // Validate Sale Id
            RuleFor(command => command.Id)
                .NotEmpty()
                .WithMessage("Sale Id must not be empty.");

            // Validate Sale Number
            RuleFor(command => command.SaleNumber)
                .NotEmpty()
                .WithMessage("Sale number must not be empty.")
                .MaximumLength(50)
                .WithMessage("Sale number must not exceed 50 characters.");

            // Validate Sale Date
            RuleFor(command => command.SaleDate)
                .NotEmpty()
                .WithMessage("Sale date must not be empty.")
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Sale date cannot be in the future.");

            // Validate Customer Id
            RuleFor(command => command.CustomerId)
                .NotEmpty()
                .WithMessage("Customer Id must not be empty.");

            // Validate Branch Id
            RuleFor(command => command.BranchId)
                .NotEmpty()
                .WithMessage("Branch Id must not be empty.");

            // Validate Items
            RuleFor(command => command.Items)
                .NotEmpty()
                .WithMessage("At least one item must be included in the sale.")
                .Must(items => items.All(item => item.Quantity > 0))
                .WithMessage("Item quantities must be greater than zero.")
                .Must(items => items.All(item => item.Quantity <= 20))
                .WithMessage("Item quantities must not exceed 20.");

            // Validate Total Amount
            RuleFor(command => command.TotalAmount)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Total amount must be greater than or equal to zero.");

            // Validate Cancellation Status
            RuleFor(command => command.IsCancelled)
                .NotNull()
                .WithMessage("Cancellation status must be specified.");
        }
    }
}
