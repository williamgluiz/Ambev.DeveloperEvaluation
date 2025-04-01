using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.DeleteProduct
{
    /// <summary>
    /// Command for deleting a Product.
    /// </summary>
    /// <remarks>
    /// This command captures the unique identifier of the Product to be deleted. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="DeleteProductRessult"/>.
    /// </remarks>
    public class DeleteProductCommand : IRequest<DeleteProductResult>
    {
        public DeleteProductCommand(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets the unique identifier of the Product to be deleted.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using DeleteProductCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new DeleteProductCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
