using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetAll;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProducts
{
    /// <summary>
    /// Handler for processing GetAllProductsCommand requests.
    /// </summary>
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, GetAllProductsResult>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetAllProductsQueryHandler.
        /// </summary>
        /// <param name="ProductRepository">The Product repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetAllProductsQueryHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetAllProductsCommand request.
        /// </summary>
        /// <param name="query">The GetAllProducts command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing all Product details.</returns>
        public async Task<GetAllProductsResult> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
        {
            var validator = new GetAllProductsQueryValidator();
            var validationResult = await validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var products = await _ProductRepository.GetAllAsync();
            return new GetAllProductsResult
            {
                Products = _mapper.Map<IEnumerable<ProductResult>>(products),
                TotalCount = products?.Count() > 0 ? products.Count() : 0
            };
        }
    }
}
