
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Validator for CreateSaleCommand that defines validation rules for sale creation.
    /// </summary>
    public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
    {

        /// <summary>
        /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
        /// </summary>
        public CreateSaleCommandValidator()
        {
            RuleFor(command => command.SaleNumber)
                .NotEmpty().WithMessage("Sale number must not be empty.")
                .MaximumLength(20).WithMessage("Sale number must not exceed 20 characters.");

            RuleFor(command => command.SaleDate)
                .NotEmpty().WithMessage("Sale date must not be empty.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Sale date cannot be in the future.");

            RuleFor(command => command.CustomerId)
                .NotEmpty().WithMessage("Customer ID must not be empty.");

            RuleFor(command => command.BranchId)
                .NotEmpty().WithMessage("Branch ID must not be empty.");

            RuleForEach(command => command.Items)
                .SetValidator(new SaleItemCommandModelValidator());

            RuleFor(command => command.IsCancelled)
                .NotNull().WithMessage("Cancellation status must be explicitly set.");
        }

        public class SaleItemCommandModelValidator : AbstractValidator<SaleItemCommandModel>
        {
            public SaleItemCommandModelValidator()
            {
                //RuleFor(item => item.Id)
                //    .NotEmpty().WithMessage("SaleItem ID must not be empty.");

                RuleFor(item => item.Quantity)
                    .GreaterThan(0).WithMessage("Quantity must be greater than zero.")
                    .LessThanOrEqualTo(20).WithMessage("Cannot sell more than 20 items of the same SaleItem.");

                RuleFor(item => item.UnitPrice)
                    .GreaterThan(0).WithMessage("Unit price must be greater than zero.");
            }
        }
    }
}