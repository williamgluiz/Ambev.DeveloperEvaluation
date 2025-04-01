using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.CreateProduct
{
    /// <summary>
    /// Command for creating a new Product.
    /// </summary>
    /// <remarks>
    /// This command captures the required data for creating a Product, 
    /// including name, ExternalId (Stock Keeping Unit), price, and description. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreateProductResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreateProductCommandValidator"/> to ensure fields follow required rules.
    /// </remarks>
    public class CreateProductCommand : IRequest<CreateProductResult>
    {
        /// <summary>
        /// Gets or sets the name of the Product.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price of the Product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the Product.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// External identity for referencing in other domains
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Validates the command using CreateProductCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new CreateProductCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
