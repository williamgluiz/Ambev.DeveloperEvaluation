using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.UpdateBranch
{
    /// <summary>
    /// Validator for UpdateBranchRequest
    /// </summary>
    public class UpdateBranchRequestValidator : AbstractValidator<UpdateBranchRequest>
    {
        /// <summary>
        /// Initializes validation rules for UpdateBranchRequest
        /// </summary>
        public UpdateBranchRequestValidator()
        {
            RuleFor(branch => branch.Id)
                .NotEmpty().WithMessage("Branch ID must not be empty.");

            RuleFor(branch => branch.Name)
                .NotEmpty().WithMessage("Branch name must not be empty.")
                .MaximumLength(100).WithMessage("Branch name must not exceed 100 characters.");

            RuleFor(branch => branch.ExternalId)
                .NotEmpty().WithMessage("External ID must not be empty.")
                .MaximumLength(50).WithMessage("External ID must not exceed 50 characters.");

            RuleFor(branch => branch.Description)
                .NotEmpty().WithMessage("Branch description must not be empty.")
                .MaximumLength(200).WithMessage("Branch description must not exceed 200 characters.");
        }
    }
}
