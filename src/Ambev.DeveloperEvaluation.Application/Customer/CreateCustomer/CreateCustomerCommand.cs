using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.CreateCustomer
{
    /// <summary>
    /// Command for creating a new customer.
    /// </summary>
    /// <remarks>
    /// This command captures the required data for creating a customer, 
    /// including name, external ID, and description. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreateCustomerResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreateCustomerCommandValidator"/> to ensure the fields follow required rules.
    /// </remarks>
    public class CreateCustomerCommand : IRequest<CreateCustomerResult>
    {
        /// <summary>
        /// Gets or sets the name of the customer to be created.
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
        /// Validates the command using CreateCustomerCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new CreateCustomerCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
