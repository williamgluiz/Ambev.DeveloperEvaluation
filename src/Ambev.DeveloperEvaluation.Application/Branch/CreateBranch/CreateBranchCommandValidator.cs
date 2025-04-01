using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Branch.CreateBranch
{
    /// <summary>
    /// Validator for CreateBranchCommand that defines validation rules for branch creation.
    /// </summary>
    public class CreateBranchCommandValidator : AbstractValidator<CreateBranchCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateBranchCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, must be between 3 and 100 characters.
        /// - External ID: Required, must not exceed 50 characters.
        /// - Description: Optional, must not exceed 255 characters.
        /// </remarks>
        public CreateBranchCommandValidator()
        {
            RuleFor(branch => branch.Name)
                .NotEmpty()
                .Length(3, 100);

            RuleFor(branch => branch.ExternalId)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(branch => branch.Description)
                .MaximumLength(255);
        }
    }
}
