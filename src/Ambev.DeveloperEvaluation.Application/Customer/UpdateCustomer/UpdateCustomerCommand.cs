using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    /// <summary>
    /// Command for updating an existing customer.
    /// </summary>
    /// <remarks>
    /// This command captures the required data for updating a customer, 
    /// including its unique identifier, name, external ID, and description. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="UpdateCustomerResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="UpdateCustomerCommandValidator"/> to ensure the fields follow the required rules.
    /// </remarks>
    public class UpdateCustomerCommand : IRequest<UpdateCustomerResult>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the customer to be updated.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the external ID for the customer.
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the customer.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Validates the command using UpdateCustomerCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new UpdateCustomerCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
