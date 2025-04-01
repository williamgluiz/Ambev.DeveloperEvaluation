using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomers
{
    /// <summary>
    /// Validator for GetAllCustomersQuery.
    /// </summary>
    /// <remarks>
    /// This validator is primarily used for consistency in the query structure, 
    /// even though GetAllCustomersQuery does not require specific rules.
    /// </remarks>
    public class GetAllCustomersQueryValidator : AbstractValidator<GetAllCustomersQuery>
    {
        /// <summary>
        /// Initializes a new instance of the GetAllCustomersQueryValidator.
        /// </summary>
        /// <remarks>
        /// Validation rules may be added in the future if needed.
        /// </remarks>
        public GetAllCustomersQueryValidator()
        {
        }
    }
}
