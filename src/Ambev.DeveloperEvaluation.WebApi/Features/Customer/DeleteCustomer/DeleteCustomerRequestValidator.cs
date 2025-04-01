using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.DeleteCustomer
{
    /// <summary>
    /// Validator for DeleteCustomerRequest
    /// </summary>
    public class DeleteCustomerRequestValidator : AbstractValidator<DeleteCustomerRequest>
    {
        /// <summary>
        /// Initializes validation rules for DeleteCustomerRequest
        /// </summary>
        public DeleteCustomerRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("Customer ID must not be empty.");
        }
    }
}
