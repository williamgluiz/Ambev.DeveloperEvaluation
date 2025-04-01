using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Product.UpdateProduct
{
    /// <summary>
    /// Handler for processing UpdateProductCommand requests.
    /// </summary>
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, UpdateProductResult>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateProductHandler.
        /// </summary>
        /// <param name="ProductRepository">The Product repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public UpdateProductHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateProductCommand request.
        /// </summary>
        /// <param name="command">The UpdateProduct command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response indicating the result of the update.</returns>
        public async Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var validator = new UpdateProductCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var Product = await _ProductRepository.GetByIdAsync(command.Id);
            if (Product == null)
                throw new KeyNotFoundException($"Product with ID {command.Id} not found.");

            Product.UpdateProduct(command.Name, command.Description, command.Price);

            var updatedProduct = await _ProductRepository.UpdateAsync(Product);

            return _mapper.Map<UpdateProductResult>(updatedProduct);
        }
    }
}
