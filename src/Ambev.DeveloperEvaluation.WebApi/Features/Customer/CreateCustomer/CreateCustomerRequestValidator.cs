using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.CreateCustomer
{
    /// <summary>
    /// Validator for CreateCustomerRequest
    /// </summary>
    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        /// <summary>
        /// Initializes validation rules for CreateCustomerRequest
        /// </summary>
        public CreateCustomerRequestValidator()
        {
            RuleFor(customer => customer.Name)
                .NotEmpty().WithMessage("Customer name must not be empty.")
                .MaximumLength(100).WithMessage("Customer name must not exceed 100 characters.");

            RuleFor(customer => customer.ExternalId)
                .NotEmpty().WithMessage("External ID must not be empty.")
                .MaximumLength(50).WithMessage("External ID must not exceed 50 characters.");

            RuleFor(customer => customer.Description)
                .NotEmpty().WithMessage("Customer description must not be empty.")
                .MaximumLength(200).WithMessage("Customer description must not exceed 200 characters.");
        }
    }
}
