using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.DeleteProduct
{
    /// <summary>
    /// Validator for DeleteProductRequest
    /// </summary>
    public class DeleteProductRequestValidator : AbstractValidator<DeleteProductRequest>
    {
        /// <summary>
        /// Initializes validation rules for DeleteProductRequest
        /// </summary>
        public DeleteProductRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("Product ID must not be empty.");
        }
    }
}
