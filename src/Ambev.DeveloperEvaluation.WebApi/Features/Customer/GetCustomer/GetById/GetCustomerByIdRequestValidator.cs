using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetById
{
    /// <summary>
    /// Validator for GetCustomerByIdRequest
    /// </summary>
    public class GetCustomerByIdRequestValidator : AbstractValidator<GetCustomerByIdRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetCustomerByIdRequest
        /// </summary>
        public GetCustomerByIdRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("Customer ID must not be empty.");
        }
    }
}
