using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branch.DeleteBranch
{
    /// <summary>
    /// Command for deleting a branch.
    /// </summary>
    /// <remarks>
    /// This command captures the data required to delete a branch, 
    /// specifically the unique identifier of the branch to be deleted. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="DeleteBranchResult"/>.
    /// </remarks>
    public class DeleteBranchCommand : IRequest<DeleteBranchResult>
    {
        public DeleteBranchCommand(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets the unique identifier of the branch to be deleted.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the command using DeleteBranchCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new DeleteBranchCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
