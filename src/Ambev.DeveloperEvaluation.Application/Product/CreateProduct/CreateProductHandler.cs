using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.CreateProduct
{
    /// <summary>
    /// Handler for processing CreateProductCommand requests.
    /// </summary>
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of CreateProductHandler.
        /// </summary>
        /// <param name="ProductRepository">The Product repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public CreateProductHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the CreateProductCommand request.
        /// </summary>
        /// <param name="command">The CreateProduct command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The created Product details.</returns>
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateProductCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var existingProduct = await _ProductRepository.GetByNameAsync(command.Name, cancellationToken);
            if (existingProduct != null)
                throw new InvalidOperationException($"Product with name {command.Name} already exists.");

            var Product = _mapper.Map<Domain.Entities.Product>(command);
            var createdProduct = await _ProductRepository.AddAsync(Product);
            return _mapper.Map<CreateProductResult>(createdProduct);
        }
    }
}
