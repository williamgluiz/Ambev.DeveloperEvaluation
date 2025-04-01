using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.DeleteProduct
{
    /// <summary>
    /// Handler for processing DeleteProductCommand requests.
    /// </summary>
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, DeleteProductResult>
    {
        private readonly IProductRepository _ProductRepository;

        /// <summary>
        /// Initializes a new instance of DeleteProductHandler.
        /// </summary>
        /// <param name="ProductRepository">The Product repository.</param>
        public DeleteProductHandler(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        /// <summary>
        /// Handles the DeleteProductCommand request.
        /// </summary>
        /// <param name="command">The DeleteProduct command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response indicating the result of the deletion.</returns>
        public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            var validator = new DeleteProductCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var Product = await _ProductRepository.GetByIdAsync(command.Id);
            if (Product == null)
                throw new KeyNotFoundException($"Product with ID {command.Id} not found.");

            await _ProductRepository.DeleteAsync(command.Id);

            return new DeleteProductResult
            {
                Success = true,
                Message = "Product deleted successfully."
            };
        }
    }
}
