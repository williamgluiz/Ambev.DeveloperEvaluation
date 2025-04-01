using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Product.UpdateProduct
{
    /// <summary>
    /// Validator for UpdateProductCommand that defines validation rules for Product updates.
    /// </summary>
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateProductCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// - Name: Required, must be between 3 and 100 characters.
        /// - ExternalId: Required, must not exceed 50 characters.
        /// - Price: Must be a positive value.
        /// - Description: Optional, must not exceed 255 characters.
        /// </remarks>
        public UpdateProductCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Product ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Product ID cannot be an empty GUID.");

            RuleFor(command => command.Name)
                .NotEmpty()
                .Length(3, 100).WithMessage("Product name must be between 3 and 100 characters.");

            RuleFor(command => command.ExternalId)
                .NotEmpty()
                .MaximumLength(50).WithMessage("External Id must not exceed 50 characters.");

            RuleFor(command => command.Price)
                .GreaterThan(0).WithMessage("Price must be a positive value.");

            RuleFor(command => command.Description)
                .MaximumLength(255).WithMessage("Description must not exceed 255 characters.");
        }
    }
}
