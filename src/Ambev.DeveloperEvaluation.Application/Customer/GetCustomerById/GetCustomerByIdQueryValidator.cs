using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomerById
{
    /// <summary>
    /// Validator for GetCustomerByIdQuery that defines validation rules for customer retrieval.
    /// </summary>
    public class GetCustomerByIdQueryValidator : AbstractValidator<GetCustomerByIdQuery>
    {
        /// <summary>
        /// Initializes a new instance of the GetCustomerByIdQueryValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public GetCustomerByIdQueryValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Customer ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Customer ID cannot be an empty GUID.");
        }
    }
}
