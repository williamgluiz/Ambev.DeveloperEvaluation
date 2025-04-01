using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSaleById
{
    /// <summary>
    /// Validator for GetSaleByIdCommand that defines validation rules for sale retrieval.
    /// </summary>
    public class GetSaleByIdCommandValidator : AbstractValidator<GetSaleByIdCommand>
    {
        /// <summary>
        /// Initializes a new instance of the GetSaleByIdCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public GetSaleByIdCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Sale ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Sale ID cannot be an empty GUID.");
        }
    }
}
