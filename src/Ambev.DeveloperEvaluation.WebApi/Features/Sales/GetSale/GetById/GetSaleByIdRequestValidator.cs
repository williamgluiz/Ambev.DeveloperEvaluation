namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetById
{
    using FluentValidation;

    /// <summary>
    /// Validator for GetSaleByIdRequest to ensure the SaleId is valid
    /// </summary>
    public class GetSaleByIdRequestValidator : AbstractValidator<GetSaleByIdRequest>
    {
        /// <summary>
        /// Initializes a new instance of the GetSaleByIdRequestValidator class
        /// </summary>
        public GetSaleByIdRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("SaleId is required.");
        }
    }
}
