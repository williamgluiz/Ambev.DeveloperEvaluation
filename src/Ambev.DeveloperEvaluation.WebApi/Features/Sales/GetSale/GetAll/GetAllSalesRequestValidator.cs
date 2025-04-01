using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetAll
{
    /// <summary>
    /// Validator for GetAllSalesRequest
    /// </summary>
    public class GetAllSalesRequestValidator : AbstractValidator<GetAllSalesRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetAllSalesRequest
        /// </summary>
        public GetAllSalesRequestValidator()
        {
            RuleFor(x => x.Take)
                .GreaterThan(0).WithMessage("Take must be greater than zero.")
                .LessThanOrEqualTo(100).WithMessage("Take must not exceed 100 records.");

            RuleFor(x => x.Skip)
                .GreaterThanOrEqualTo(0).WithMessage("Skip must be zero or greater.");
        }
    }
}
