using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItemById
{
    /// <summary>
    /// Validator for GetSaleItemByIdCommand that defines validation rules for sale item retrieval.
    /// </summary>
    public class GetSaleItemByIdCommandValidator : AbstractValidator<GetSaleItemByIdCommand>
    {
        /// <summary>
        /// Initializes a new instance of the GetSaleItemByIdCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public GetSaleItemByIdCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Sale item ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Sale item ID cannot be an empty GUID.");
        }
    }
}
