using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.UpdateSaleItem
{
    /// <summary>
    /// Handler for processing UpdateSaleItemCommand requests.
    /// </summary>
    public class UpdateSaleItemHandler : IRequestHandler<UpdateSaleItemCommand, UpdateSaleItemResult>
    {
        private readonly ISaleItemRepository _saleItemRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateSaleItemHandler.
        /// </summary>
        /// <param name="saleItemRepository">The sale item repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public UpdateSaleItemHandler(ISaleItemRepository saleItemRepository, IMapper mapper)
        {
            _saleItemRepository = saleItemRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateSaleItemCommand request.
        /// </summary>
        /// <param name="command">The UpdateSaleItem command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response indicating the result of the update.</returns>
        public async Task<UpdateSaleItemResult> Handle(UpdateSaleItemCommand command, CancellationToken cancellationToken)
        {
            var validator = new UpdateSaleItemCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var saleItem = await _saleItemRepository.GetByIdAsync(command.Id, cancellationToken);
            if (saleItem == null)
                throw new KeyNotFoundException($"Sale item with ID {command.Id} not found.");

            saleItem.UpdateSaleItem(command.SaleId, command.Quantity, command.UnitPrice);

            var updatedSaleItem = await _saleItemRepository.UpdateAsync(saleItem, cancellationToken);

            return _mapper.Map<UpdateSaleItemResult>(updatedSaleItem);
        }
    }
}
