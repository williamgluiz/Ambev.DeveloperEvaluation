using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranchById
{
    /// <summary>
    /// Validator for GetBranchByIdQuery that defines validation rules for branch retrieval.
    /// </summary>
    public class GetBranchByIdQueryValidator : AbstractValidator<GetBranchByIdQuery>
    {
        /// <summary>
        /// Initializes a new instance of the GetBranchByIdQueryValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public GetBranchByIdQueryValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Branch ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Branch ID cannot be an empty GUID.");
        }
    }
}
