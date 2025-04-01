using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSaleById
{
    /// <summary>
    /// Handler for processing GetSaleByIdCommand requests.
    /// </summary>
    public class GetSaleByIdHandler : IRequestHandler<GetSaleByIdCommand, GetSaleByIdResult>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetSaleByIdHandler.
        /// </summary>
        /// <param name="saleRepository">The sale repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetSaleByIdHandler(ISaleRepository saleRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetSaleByIdCommand request.
        /// </summary>
        /// <param name="command">The GetSaleById command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing sale details.</returns>
        public async Task<GetSaleByIdResult> Handle(GetSaleByIdCommand command, CancellationToken cancellationToken)
        {
            var validator = new GetSaleByIdCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var sale = await _saleRepository.GetByIdWithItemsAsync(command.Id, cancellationToken);
            if (sale == null)
                throw new KeyNotFoundException($"Sale with ID {command.Id} not found.");

            return _mapper.Map<GetSaleByIdResult>(sale);
        }
    }
}
