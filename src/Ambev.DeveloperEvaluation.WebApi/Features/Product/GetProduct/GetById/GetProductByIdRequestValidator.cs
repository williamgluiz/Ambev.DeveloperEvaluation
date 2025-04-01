using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetById
{
    /// <summary>
    /// Validator for GetProductByIdRequest
    /// </summary>
    public class GetProductByIdRequestValidator : AbstractValidator<GetProductByIdRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetProductByIdRequest
        /// </summary>
        public GetProductByIdRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("Product ID must not be empty.");
        }
    }
}
