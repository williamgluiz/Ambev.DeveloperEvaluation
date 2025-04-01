using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.CreateSaleItem
{
    /// <summary>
    /// Command for creating a new sale item.
    /// </summary>
    /// <remarks>
    /// This command captures the required data for adding an item to a sale, 
    /// including SaleId, Quantity, and UnitPrice. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreateSaleItemResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreateSaleItemCommandValidator"/> to ensure fields follow required rules.
    /// </remarks>
    public class CreateSaleItemCommand : IRequest<CreateSaleItemResult>
    {
        /// <summary>
        /// Gets or sets the identifier of the associated sale.
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the SaleItem being sold.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the SaleItem.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Validates the command using CreateSaleItemCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new CreateSaleItemCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
