using FluentValidation;
using System;
using System.Linq;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// Validator for CreateSaleRequest that defines validation rules for sale creation.
    /// </summary>
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
        /// </summary>
        public CreateSaleRequestValidator()
        {
            RuleFor(sale => sale.SaleNumber)
                .NotEmpty().WithMessage("Sale number must not be empty.")
                .MaximumLength(50).WithMessage("Sale number must not exceed 50 characters.");

            RuleFor(sale => sale.SaleDate)
                .NotEmpty().WithMessage("Sale date must not be empty.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Sale date cannot be in the future.");

            RuleFor(sale => sale.CustomerId)
                .NotEmpty().WithMessage("Customer ID must not be empty.");

            RuleFor(sale => sale.BranchId)
                .NotEmpty().WithMessage("Branch ID must not be empty.");

            RuleFor(sale => sale.Items)
                .NotEmpty().WithMessage("The sale must contain at least one item.")
                // Se não houver um validator separado para os itens, podemos incluir regras inline:
                .Must(items => items.All(item => item.Quantity > 0))
                .WithMessage("Each item must have a quantity greater than zero.")
                .Must(items => items.All(item => item.Quantity <= 20))
                .WithMessage("Cannot sell more than 20 items of the same SaleItem.");

            // Se for possível definir um validator para cada item:
            RuleForEach(sale => sale.Items)
                .SetValidator(new SaleItemRequestModelValidator());

            //RuleFor(sale => sale.TotalAmount)
            //    .GreaterThanOrEqualTo(0).WithMessage("Total amount must be greater than or equal to zero.");
        }
    }

    public class SaleItemRequestModelValidator : AbstractValidator<SaleItemRequestModel>
    {
        public SaleItemRequestModelValidator()
        {
            //RuleFor(item => item.Id)
            //    .NotEmpty().WithMessage("SaleItem ID is required.");

            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than zero.")
                .LessThanOrEqualTo(20).WithMessage("Cannot sell more than 20 items.");

            RuleFor(item => item.UnitPrice)
                .GreaterThan(0).WithMessage("Unit price must be greater than zero.");
        }
    }
}