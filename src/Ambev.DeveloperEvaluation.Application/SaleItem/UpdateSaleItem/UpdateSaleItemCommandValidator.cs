using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.UpdateSaleItem
{
    /// <summary>
    /// Validator for UpdateSaleItemCommand that defines validation rules for sale item updates.
    /// </summary>
    public class UpdateSaleItemCommandValidator : AbstractValidator<UpdateSaleItemCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSaleItemCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// - SaleId: Must be a valid GUID and not empty.
        /// - Quantity: Must be greater than 0.
        /// - UnitPrice: Must be a positive value.
        /// </remarks>
        public UpdateSaleItemCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Sale item ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Sale item ID cannot be an empty GUID.");

            RuleFor(command => command.SaleId)
                .NotEmpty().WithMessage("Sale ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Sale ID cannot be an empty GUID.");

            RuleFor(command => command.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than 0.");

            RuleFor(command => command.UnitPrice)
                .GreaterThan(0).WithMessage("Unit price must be a positive value.");
        }
    }
}
