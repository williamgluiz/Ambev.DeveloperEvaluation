using Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetAll;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProducts
{
    /// <summary>
    /// Validator for GetAllProductsCommand.
    /// </summary>
    /// <remarks>
    /// This validator is primarily used for consistency in the command structure, 
    /// even though GetAllProductsQuery does not require specific rules.
    /// </remarks>
    public class GetAllProductsQueryValidator : AbstractValidator<GetAllProductsQuery>
    {
        /// <summary>
        /// Initializes a new instance of the GetAllProductsQueryValidator.
        /// </summary>
        /// <remarks>
        /// Validation rules may be added in the future if needed.
        /// </remarks>
        public GetAllProductsQueryValidator()
        {
        }
    }
}
