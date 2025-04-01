using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetAll
{
    /// <summary>
    /// Validator for GetAllSaleItemsRequest
    /// </summary>
    public class GetAllSaleItemsRequestValidator : AbstractValidator<GetAllSaleItemsRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetAllSaleItemsRequest
        /// </summary>
        public GetAllSaleItemsRequestValidator()
        {
            RuleFor(request => request.Take)
                .GreaterThan(0).WithMessage("Take must be greater than zero.")
                .LessThanOrEqualTo(100).WithMessage("Take must not exceed 100 records.");

            RuleFor(request => request.Skip)
                .GreaterThanOrEqualTo(0).WithMessage("Skip must be zero or greater.");
        }
    }
}
