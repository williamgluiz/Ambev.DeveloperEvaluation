using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.UpdateSaleItem
{
    /// <summary>
    /// Command for updating an existing sale item.
    /// </summary>
    /// <remarks>
    /// This command captures the required data for updating a sale item, 
    /// including its unique identifier, SaleItemId, Quantity, and UnitPrice. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="UpdateSaleItemResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="UpdateSaleItemCommandValidator"/> to ensure fields follow the required rules.
    /// </remarks>
    public class UpdateSaleItemCommand : IRequest<UpdateSaleItemResult>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale item to be updated.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated sale.
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the SaleItem in the sale item.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the SaleItem in the sale item.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Validates the command using UpdateSaleItemCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new UpdateSaleItemCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
