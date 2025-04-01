using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.DeleteSaleItem
{
    /// <summary>
    /// Validator for DeleteSaleItemRequest
    /// </summary>
    public class DeleteSaleItemRequestValidator : AbstractValidator<DeleteSaleItemRequest>
    {
        /// <summary>
        /// Initializes validation rules for DeleteSaleItemRequest
        /// </summary>
        public DeleteSaleItemRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("Sale item ID must not be empty.");
        }
    }
}
