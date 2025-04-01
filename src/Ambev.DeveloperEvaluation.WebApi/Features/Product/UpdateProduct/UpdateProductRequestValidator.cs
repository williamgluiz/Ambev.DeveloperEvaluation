using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.UpdateProduct
{
    /// <summary>
    /// Validator for UpdateProductRequest
    /// </summary>
    public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
    {
        /// <summary>
        /// Initializes validation rules for UpdateProductRequest
        /// </summary>
        public UpdateProductRequestValidator()
        {
            RuleFor(Product => Product.Id)
                .NotEmpty().WithMessage("Product ID must not be empty.");

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
