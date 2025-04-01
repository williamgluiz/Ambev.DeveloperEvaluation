using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.UpdateCustomer
{
    /// <summary>
    /// Validator for UpdateCustomerRequest
    /// </summary>
    public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
    {
        /// <summary>
        /// Initializes validation rules for UpdateCustomerRequest
        /// </summary>
        public UpdateCustomerRequestValidator()
        {
            RuleFor(customer => customer.Id)
                .NotEmpty().WithMessage("Customer ID must not be empty.");

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
