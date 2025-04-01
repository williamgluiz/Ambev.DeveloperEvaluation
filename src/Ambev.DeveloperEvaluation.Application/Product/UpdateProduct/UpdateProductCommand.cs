using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Product.UpdateProduct
{
    /// <summary>
    /// Command for updating an existing Product.
    /// </summary>
    /// <remarks>
    /// This command captures the required data for updating a Product, 
    /// including its unique identifier, name, ExternalId, price, and description. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="UpdateProductResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="UpdateProductCommandValidator"/> to ensure the fields follow the required rules.
    /// </remarks>
    public class UpdateProductCommand : IRequest<UpdateProductResult>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the Product to be updated.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the Product.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// External identity for referencing in other domains
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price of the Product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the Product.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Validates the command using UpdateProductCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new UpdateProductCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
