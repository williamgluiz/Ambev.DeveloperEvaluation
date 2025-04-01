using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.Update
{
    /// <summary>
    /// Validator for UpdateSaleItemRequest
    /// </summary>
    public class UpdateSaleItemRequestValidator : AbstractValidator<UpdateSaleItemRequest>
    {
        /// <summary>
        /// Initializes validation rules for UpdateSaleItemRequest
        /// </summary>
        public UpdateSaleItemRequestValidator()
        {
            RuleFor(item => item.Id)
                .NotEmpty().WithMessage("Sale item ID must not be empty.");

            RuleFor(item => item.SaleId)
                .NotEmpty().WithMessage("Sale ID must not be empty.");

            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than zero.")
                .LessThanOrEqualTo(20).WithMessage("Quantity must not exceed the maximum allowed.");

            RuleFor(item => item.UnitPrice)
                .GreaterThan(0).WithMessage("Unit price must be greater than zero.");
        }
    }
}
