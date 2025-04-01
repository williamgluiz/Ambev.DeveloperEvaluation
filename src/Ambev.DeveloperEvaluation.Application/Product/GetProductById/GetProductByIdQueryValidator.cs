using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProductById
{
    /// <summary>
    /// Validator for GetProductByIdQuery that defines validation rules for Product retrieval.
    /// </summary>
    public class GetProductByIdQueryValidator : AbstractValidator<GetProductByIdQuery>
    {
        /// <summary>
        /// Initializes a new instance of the GetProductByIdQueryValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public GetProductByIdQueryValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Product ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Product ID cannot be an empty GUID.");
        }
    }
}
