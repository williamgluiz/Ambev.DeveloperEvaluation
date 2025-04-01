using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.CreateProduct
{
    /// <summary>
    /// Validator for CreateProductRequest
    /// </summary>
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        /// <summary>
        /// Initializes validation rules for CreateProductRequest
        /// </summary>
        public CreateProductRequestValidator()
        {
            RuleFor(Product => Product.Name)
                .NotEmpty().WithMessage("Product name must not be empty.")
                .MaximumLength(100).WithMessage("Product name must not exceed 100 characters.");

            RuleFor(Product => Product.ExternalId)
                .NotEmpty().WithMessage("External ID must not be empty.")
                .MaximumLength(50).WithMessage("External ID must not exceed 50 characters.");

            RuleFor(Product => Product.Description)
                .NotEmpty().WithMessage("Product description must not be empty.")
                .MaximumLength(200).WithMessage("Product description must not exceed 200 characters.");

            RuleFor(Product => Product.Price)
                .GreaterThan(0).WithMessage("Product price must be greater than zero.");
        }
    }
}
