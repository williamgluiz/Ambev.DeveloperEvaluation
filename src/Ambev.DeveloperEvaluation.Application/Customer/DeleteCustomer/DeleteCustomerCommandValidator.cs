using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.DeleteCustomer
{
    /// <summary>
    /// Validator for DeleteCustomerCommand that defines validation rules for customer deletion.
    /// </summary>
    public class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
    {
        /// <summary>
        /// Initializes a new instance of the DeleteCustomerCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public DeleteCustomerCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Customer ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Customer ID cannot be an empty GUID.");
        }
    }
}
