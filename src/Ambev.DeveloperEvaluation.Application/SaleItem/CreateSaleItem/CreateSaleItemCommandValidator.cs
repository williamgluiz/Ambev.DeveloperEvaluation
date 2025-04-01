using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.CreateSaleItem
{
    /// <summary>
    /// Validator for CreateSaleItemCommand that defines validation rules for sale item creation.
    /// </summary>
    public class CreateSaleItemCommandValidator : AbstractValidator<CreateSaleItemCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleItemCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - SaleId: Must be a valid GUID and not empty.
        /// - Quantity: Must be greater than 0.
        /// - UnitPrice: Must be a positive value.
        /// </remarks>
        public CreateSaleItemCommandValidator()
        {
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
