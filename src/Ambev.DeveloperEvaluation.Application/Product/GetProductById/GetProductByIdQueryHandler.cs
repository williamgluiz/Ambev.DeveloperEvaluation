using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProductById
{
    /// <summary>
    /// Handler for processing GetProductByIdQuery requests.
    /// </summary>
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdResult>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetProductByIdQueryHandler.
        /// </summary>
        /// <param name="ProductRepository">The Product repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetProductByIdQueryHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetProductByIdQuery request.
        /// </summary>
        /// <param name="query">The GetProductById query.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing Product details.</returns>
        public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            var validator = new GetProductByIdQueryValidator();
            var validationResult = await validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var Product = await _ProductRepository.GetByIdAsync(query.Id);
            if (Product == null)
                throw new KeyNotFoundException($"Product with ID {query.Id} not found.");

            return _mapper.Map<GetProductByIdResult>(Product);
        }
    }
}
