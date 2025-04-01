using Ambev.DeveloperEvaluation.Application.SaleItem.CreateSaleItem;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.DeleteSaleItem
{
    /// <summary>
    /// Handler for processing DeleteSaleItemCommand requests.
    /// </summary>
    public class DeleteSaleItemHandler : IRequestHandler<DeleteSaleItemCommand, DeleteSaleItemResult>
    {
        private readonly ISaleItemRepository _saleItemRepository;

        /// <summary>
        /// Initializes a new instance of DeleteSaleItemHandler.
        /// </summary>
        /// <param name="saleItemRepository">The sale item repository.</param>
        public DeleteSaleItemHandler(ISaleItemRepository saleItemRepository)
        {
            _saleItemRepository = saleItemRepository;
        }

        /// <summary>
        /// Handles the DeleteSaleItemCommand request.
        /// </summary>
        /// <param name="command">The DeleteSaleItem command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response indicating the result of the deletion.</returns>
        public async Task<DeleteSaleItemResult> Handle(DeleteSaleItemCommand command, CancellationToken cancellationToken)
        {
            var validator = new DeleteSaleItemCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var saleItem = await _saleItemRepository.GetByIdAsync(command.Id, cancellationToken);
            if (saleItem == null)
                throw new KeyNotFoundException($"Sale item with ID {command.Id} not found.");

            await _saleItemRepository.DeleteAsync(command.Id, cancellationToken);

            return new DeleteSaleItemResult
            {
                Success = true,
                Message = "Sale item deleted successfully."
            };
        }
    }
}
