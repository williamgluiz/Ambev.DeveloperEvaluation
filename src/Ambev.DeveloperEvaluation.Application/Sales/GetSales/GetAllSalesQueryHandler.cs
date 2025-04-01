using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    /// <summary>
    /// Handler for processing GetAllSalesQuery requests.
    /// </summary>
    public class GetAllSalesQueryHandler : IRequestHandler<GetAllSalesQuery, GetAllSalesResult>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetAllSalesQueryHandler.
        /// </summary>
        /// <param name="saleRepository">The sale repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetAllSalesQueryHandler(ISaleRepository saleRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetAllSalesQuery request.
        /// </summary>
        /// <param name="query">The GetAllSales query.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing all sale details.</returns>
        public async Task<GetAllSalesResult> Handle(GetAllSalesQuery query, CancellationToken cancellationToken)
        {
            var validator = new GetAllSalesQueryValidator();
            var validationResult = await validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var sales = await _saleRepository.GetAllAsync(cancellationToken);
            return new GetAllSalesResult
            {
                Sales = _mapper.Map<IEnumerable<SaleResult>>(sales),
                TotalCount = sales?.Count() > 0 ? sales.Count() : 0
            };
        }
    }
}
