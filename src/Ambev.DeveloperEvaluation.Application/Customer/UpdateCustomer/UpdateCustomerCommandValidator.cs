using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    /// <summary>
    /// Validator for UpdateCustomerCommand that defines validation rules for customer updates.
    /// </summary>
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateCustomerCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// - Name: Required, must be between 3 and 100 characters.
        /// - External ID: Required, must not exceed 50 characters.
        /// - Description: Optional, must not exceed 255 characters.
        /// </remarks>
        public UpdateCustomerCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Customer ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Customer ID cannot be an empty GUID.");

            RuleFor(command => command.Name)
                .NotEmpty().Length(3, 100).WithMessage("Customer name must be between 3 and 100 characters.");

            RuleFor(command => command.ExternalId)
                .NotEmpty().MaximumLength(50).WithMessage("External ID must not exceed 50 characters.");

            RuleFor(command => command.Description)
                .MaximumLength(255).WithMessage("Description must not exceed 255 characters.");
        }
    }
}
