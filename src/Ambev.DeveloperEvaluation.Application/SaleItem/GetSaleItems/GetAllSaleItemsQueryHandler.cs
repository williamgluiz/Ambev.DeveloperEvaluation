using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems
{
    /// <summary>
    /// Handler for processing GetAllSaleItemsQuery requests.
    /// </summary>
    public class GetAllSaleItemsQueryHandler : IRequestHandler<GetAllSaleItemsQuery, GetAllSaleItemsResult>
    {
        private readonly ISaleItemRepository _saleItemRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetAllSaleItemsQueryHandler.
        /// </summary>
        /// <param name="saleItemRepository">The sale item repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetAllSaleItemsQueryHandler(ISaleItemRepository saleItemRepository, IMapper mapper)
        {
            _saleItemRepository = saleItemRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetAllSaleItemsQuery request.
        /// </summary>
        /// <param name="query">The GetAllSaleItems query.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing all sale item details.</returns>
        public async Task<GetAllSaleItemsResult> Handle(GetAllSaleItemsQuery query, CancellationToken cancellationToken)
        {
            var validator = new GetAllSaleItemsQueryValidator();
            var validationResult = await validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var saleItems = await _saleItemRepository.GetAllAsync(cancellationToken);
            return new GetAllSaleItemsResult
            {
                SaleItems = _mapper.Map<IEnumerable<SaleItemResult>>(saleItems),
                TotalCount = saleItems?.Count() > 0 ? saleItems.Count() : 0
            };
        }
    }
}
