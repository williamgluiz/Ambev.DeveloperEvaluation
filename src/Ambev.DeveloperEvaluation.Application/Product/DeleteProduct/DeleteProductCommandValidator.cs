using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.DeleteProduct
{
    /// <summary>
    /// Validator for DeleteProductCommand that defines validation rules for Product deletion.
    /// </summary>
    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        /// <summary>
        /// Initializes a new instance of the DeleteProductCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public DeleteProductCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Product ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Product ID cannot be an empty GUID.");
        }
    }
}
