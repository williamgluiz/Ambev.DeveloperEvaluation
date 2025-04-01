using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.CreateSaleItem
{
    /// <summary>
    /// Handler for processing CreateSaleItemCommand requests.
    /// </summary>
    public class CreateSaleItemHandler : IRequestHandler<CreateSaleItemCommand, CreateSaleItemResult>
    {
        private readonly ISaleItemRepository _SaleItemRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of CreateSaleItemHandler.
        /// </summary>
        /// <param name="SaleItemRepository">The sale item repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public CreateSaleItemHandler(ISaleItemRepository SaleItemRepository, IMapper mapper)
        {
            _SaleItemRepository = SaleItemRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the CreateSaleItemCommand request.
        /// </summary>
        /// <param name="command">The CreateSaleItem command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The created sale item details.</returns>
        public async Task<CreateSaleItemResult> Handle(CreateSaleItemCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateSaleItemCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var SaleItem = _mapper.Map<Domain.Entities.SaleItem>(command);
            var createdSaleItem = await _SaleItemRepository.AddAsync(SaleItem);
            return _mapper.Map<CreateSaleItemResult>(createdSaleItem);
        }
    }
}
