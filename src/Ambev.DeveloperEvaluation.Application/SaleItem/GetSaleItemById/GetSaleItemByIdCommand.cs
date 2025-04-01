using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItemById
{
    /// <summary>
    /// Command for retrieving a sale item by its unique identifier.
    /// </summary>
    /// <remarks>
    /// This command captures the data required to fetch a sale item, 
    /// specifically the unique identifier of the sale item to be retrieved. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="GetSaleItemByIdResult"/>.
    /// </remarks>
    public class GetSaleItemByIdCommand : IRequest<GetSaleItemByIdResult>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale item to be retrieved.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using GetSaleItemByIdCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new GetSaleItemByIdCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
