using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.CreateProduct
{
    /// <summary>
    /// Validator for CreateProductCommand that defines validation rules for Product creation.
    /// </summary>
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, must be between 3 and 100 characters.
        /// - Price: Must be a positive value.
        /// - Description: Optional, must not exceed 255 characters.
        /// </remarks>
        public CreateProductCommandValidator()
        {
            RuleFor(command => command.Name)
                .NotEmpty()
                .Length(3, 100).WithMessage("Product name must be between 3 and 100 characters.");

            RuleFor(command => command.Price)
                .GreaterThan(0).WithMessage("Price must be a positive value.");

            RuleFor(command => command.Description)
                .MaximumLength(255).WithMessage("Description must not exceed 255 characters.");
        }
    }
}
