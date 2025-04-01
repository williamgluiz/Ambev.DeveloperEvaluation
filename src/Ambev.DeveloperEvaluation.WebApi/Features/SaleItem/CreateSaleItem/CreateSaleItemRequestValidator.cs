using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.CreateSaleItem
{
    /// <summary>
    /// Validator for CreateSaleItemRequest
    /// </summary>
    public class CreateSaleItemRequestValidator : AbstractValidator<CreateSaleItemRequest>
    {
        /// <summary>
        /// Initializes validation rules for CreateSaleItemRequest
        /// </summary>
        public CreateSaleItemRequestValidator()
        {
            RuleFor(item => item.SaleId)
                .NotEmpty().WithMessage("Sale ID must not be empty.");

            RuleFor(item => item.SaleItemId)
                .NotEmpty().WithMessage("SaleItem ID must not be empty.");

            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than zero.")
                .LessThanOrEqualTo(20).WithMessage("Quantity must not exceed the maximum allowed.");

            RuleFor(item => item.UnitPrice)
                .GreaterThan(0).WithMessage("Unit price must be greater than zero.");
        }
    }
}
