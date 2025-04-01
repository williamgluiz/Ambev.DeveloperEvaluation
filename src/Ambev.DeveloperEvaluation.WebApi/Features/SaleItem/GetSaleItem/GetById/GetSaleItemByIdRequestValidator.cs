using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetById
{
    /// <summary>
    /// Validator for GetSaleItemByIdRequest
    /// </summary>
    public class GetSaleItemByIdRequestValidator : AbstractValidator<GetSaleItemByIdRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetSaleItemByIdRequest
        /// </summary>
        public GetSaleItemByIdRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("Sale item ID must not be empty.");
        }
    }
}
