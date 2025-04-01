using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.DeleteBranch
{
    /// <summary>
    /// Validator for DeleteBranchRequest
    /// </summary>
    public class DeleteBranchRequestValidator : AbstractValidator<DeleteBranchRequest>
    {
        /// <summary>
        /// Initializes validation rules for DeleteBranchRequest
        /// </summary>
        public DeleteBranchRequestValidator()
        {
            RuleFor(branch => branch.Id)
                .NotEmpty().WithMessage("Branch ID must not be empty.");
        }
    }
}
