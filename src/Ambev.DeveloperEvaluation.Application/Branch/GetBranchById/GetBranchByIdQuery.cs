using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranchById
{
    /// <summary>
    /// Command for retrieving a branch by its unique identifier.
    /// </summary>
    /// <remarks>
    /// This command captures the data required to fetch a branch, 
    /// specifically the unique identifier of the branch to be retrieved. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="GetBranchByIdResult"/>.
    /// </remarks>
    public class GetBranchByIdQuery : IRequest<GetBranchByIdResult>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the branch to be retrieved.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using GetBranchByIdCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new GetBranchByIdQueryValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
