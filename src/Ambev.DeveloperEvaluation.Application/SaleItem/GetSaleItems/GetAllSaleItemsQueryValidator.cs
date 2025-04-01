using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems
{
    /// <summary>
    /// Validator for GetAllSaleItemsCommand.
    /// </summary>
    /// <remarks>
    /// This validator is primarily used for consistency in the command structure, 
    /// even though GetAllSaleItemsCommand does not require specific rules.
    /// </remarks>
    public class GetAllSaleItemsQueryValidator : AbstractValidator<GetAllSaleItemsQuery>
    {
        /// <summary>
        /// Initializes a new instance of the GetAllSaleItemsQueryValidator.
        /// </summary>
        /// <remarks>
        /// Validation rules may be added in the future if needed.
        /// </remarks>
        public GetAllSaleItemsQueryValidator()
        {
        }
    }
}
