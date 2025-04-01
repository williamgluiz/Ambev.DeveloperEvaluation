using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.CreateCustomer
{
    /// <summary>
    /// Validator for CreateCustomerCommand that defines validation rules for customer creation.
    /// </summary>
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateCustomerCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, must be between 3 and 100 characters.
        /// - External ID: Required, must not exceed 50 characters.
        /// - Description: Optional, must not exceed 255 characters.
        /// </remarks>
        public CreateCustomerCommandValidator()
        {
            RuleFor(command => command.Name)
                .NotEmpty()
                .Length(3, 100).WithMessage("Customer name must be between 3 and 100 characters.");

            RuleFor(command => command.ExternalId)
                .NotEmpty()
                .MaximumLength(50).WithMessage("External ID must not exceed 50 characters.");

            RuleFor(command => command.Description)
                .MaximumLength(255).WithMessage("Description must not exceed 255 characters.");
        }
    }
}
