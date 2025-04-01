

using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItemById
{
    /// <summary>
    /// Handler for processing GetSaleItemByIdCommand requests.
    /// </summary>
    public class GetSaleItemByIdHandler : IRequestHandler<GetSaleItemByIdCommand, GetSaleItemByIdResult>
    {
        private readonly ISaleItemRepository _saleItemRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetSaleItemByIdHandler.
        /// </summary>
        /// <param name="SaleItemRepository">The SaleItem repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetSaleItemByIdHandler(ISaleItemRepository saleItemRepository, IMapper mapper)
        {
            _saleItemRepository = saleItemRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetSaleItemByIdCommand request.
        /// </summary>
        /// <param name="command">The GetSaleItemById command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing SaleItem details.</returns>
        public async Task<GetSaleItemByIdResult> Handle(GetSaleItemByIdCommand command, CancellationToken cancellationToken)
        {
            var validator = new GetSaleItemByIdCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var SaleItem = await _saleItemRepository.GetByIdAsync(command.Id);
            if (SaleItem == null)
                throw new KeyNotFoundException($"SaleItem with ID {command.Id} not found.");

            return _mapper.Map<GetSaleItemByIdResult>(SaleItem);
        }
    }
}
