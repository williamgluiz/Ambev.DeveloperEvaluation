using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSaleById
{
    /// <summary>
    /// Command for retrieving a sale by its unique identifier.
    /// </summary>
    /// <remarks>
    /// This command captures the data required to fetch a sale, 
    /// specifically the unique identifier of the sale to be retrieved. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="GetSaleByIdResult"/>.
    /// </remarks>
    public class GetSaleByIdCommand : IRequest<GetSaleByIdResult>
    {
        public GetSaleByIdCommand(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets the unique identifier of the sale to be retrieved.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using GetSaleByIdCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new GetSaleByIdCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
