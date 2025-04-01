using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale
{
    /// <summary>
    /// Validator for UpdateSaleRequest
    /// </summary>
    public class UpdateSaleRequestValidator : AbstractValidator<UpdateSaleRequest>
    {
        /// <summary>
        /// Initializes validation rules for UpdateSaleRequest
        /// </summary>
        public UpdateSaleRequestValidator()
        {
            RuleFor(sale => sale.Id)
                .NotEmpty().WithMessage("Sale ID must not be empty.");

            RuleFor(sale => sale.SaleNumber)
                .NotEmpty().WithMessage("Sale number must not be empty.")
                .MaximumLength(50).WithMessage("Sale number must not exceed 50 characters.");

            RuleFor(sale => sale.SaleDate)
                .NotEmpty().WithMessage("Sale date must not be empty.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Sale date cannot be in the future.");

            RuleFor(sale => sale.CustomerId)
                .NotEmpty().WithMessage("Customer ID must not be empty.");

            RuleFor(sale => sale.BranchId)
                .NotEmpty().WithMessage("Branch ID must not be empty.");

            RuleFor(sale => sale.Items)
                .NotEmpty().WithMessage("The sale must contain at least one item.")
                .Must(items => items.All(item => item.Quantity > 0))
                .WithMessage("Each item must have a quantity greater than zero.")
                .Must(items => items.All(item => item.Quantity <= 20))
                .WithMessage("Each item must have a quantity not exceeding 20.");
        }
    }
}
