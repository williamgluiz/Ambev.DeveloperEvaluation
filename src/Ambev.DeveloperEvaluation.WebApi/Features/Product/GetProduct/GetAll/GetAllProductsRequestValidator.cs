using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetAll
{
    /// <summary>
    /// Validator for GetAllProductsRequest
    /// </summary>
    public class GetAllProductsRequestValidator : AbstractValidator<GetAllProductsRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetAllProductsRequest
        /// </summary>
        public GetAllProductsRequestValidator()
        {
            RuleFor(request => request.Take)
                .GreaterThan(0).WithMessage("Take must be greater than zero.")
                .LessThanOrEqualTo(100).WithMessage("Take must not exceed 100 records.");

            RuleFor(request => request.Skip)
                .GreaterThanOrEqualTo(0).WithMessage("Skip must be zero or greater.");
        }
    }
}
