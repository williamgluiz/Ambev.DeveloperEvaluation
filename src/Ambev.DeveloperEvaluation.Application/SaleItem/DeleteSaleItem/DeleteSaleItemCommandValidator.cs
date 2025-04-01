using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.DeleteSaleItem
{
    /// <summary>
    /// Validator for DeleteSaleItemCommand that defines validation rules for sale item deletion.
    /// </summary>
    public class DeleteSaleItemCommandValidator : AbstractValidator<DeleteSaleItemCommand>
    {
        /// <summary>
        /// Initializes a new instance of the DeleteSaleItemCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public DeleteSaleItemCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Sale item ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Sale item ID cannot be an empty GUID.");
        }
    }
}
