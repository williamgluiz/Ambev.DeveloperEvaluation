using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProductById
{
    /// <summary>
    /// Command for retrieving a Product by its unique identifier.
    /// </summary>
    /// <remarks>
    /// This command captures the data required to fetch a Product, 
    /// specifically the unique identifier of the Product to be retrieved. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="GetProductByIdResult"/>.
    /// </remarks>
    public class GetProductByIdQuery : IRequest<GetProductByIdResult>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the Product to be retrieved.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using GetProductByIdQueryValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new GetProductByIdQueryValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
