using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    /// <summary>
    /// Validator for GetAllSalesCommand.
    /// </summary>
    /// <remarks>
    /// This validator is primarily used for consistency in the command structure, 
    /// even though GetAllSalesCommand does not require specific rules.
    /// </remarks>
    public class GetAllSalesQueryValidator : AbstractValidator<GetAllSalesQuery>
    {
        /// <summary>
        /// Initializes a new instance of the GetAllSalesQueryValidator.
        /// </summary>
        /// <remarks>
        /// Validation rules may be added in the future if needed.
        /// </remarks>
        public GetAllSalesQueryValidator()
        {
        }
    }
}
