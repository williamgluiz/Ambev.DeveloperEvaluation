using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetAll
{
    /// <summary>
    /// Validator for GetAllCustomersRequest
    /// </summary>
    public class GetAllCustomersRequestValidator : AbstractValidator<GetAllCustomersRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetAllCustomersRequest
        /// </summary>
        public GetAllCustomersRequestValidator()
        {
            RuleFor(request => request.Take)
                .GreaterThan(0).WithMessage("Take must be greater than zero.")
                .LessThanOrEqualTo(100).WithMessage("Take must not exceed 100 records.");

            RuleFor(request => request.Skip)
                .GreaterThanOrEqualTo(0).WithMessage("Skip must be zero or greater.");
        }
    }
}
