using Ambev.DeveloperEvaluation.Application.SaleItem.CreateSaleItem;
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.DeleteSaleItem
{
    /// <summary>
    /// Command for deleting a sale item.
    /// </summary>
    /// <remarks>
    /// This command captures the unique identifier of the sale item to be deleted. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="DeleteSaleItemResult"/>.
    /// </remarks>
    public class DeleteSaleItemCommand : IRequest<DeleteSaleItemResult>
    {
        public DeleteSaleItemCommand(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets the unique identifier of the sale item to be deleted.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using DeleteSaleItemCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new DeleteSaleItemCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
