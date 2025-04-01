using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale
{
    /// <summary>
    /// Command for deleting a sale.
    /// </summary>
    /// <remarks>
    /// This command captures the unique identifier of the sale to be deleted. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="DeleteSaleResult"/>.
    /// </remarks>
    public class DeleteSaleCommand : IRequest<DeleteSaleResult>
    {
        public DeleteSaleCommand(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets the unique identifier of the sale to be deleted.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using DeleteSaleCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new DeleteSaleCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
