using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.DeleteCustomer
{
    /// <summary>
    /// Command for deleting a customer.
    /// </summary>
    /// <remarks>
    /// This command captures the unique identifier of the customer to be deleted. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="DeleteCustomerResponse"/>.
    /// </remarks>
    public class DeleteCustomerCommand : IRequest<DeleteCustomerResult>
    {
        public DeleteCustomerCommand(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets the unique identifier of the customer to be deleted.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using DeleteCustomerCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new DeleteCustomerCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
