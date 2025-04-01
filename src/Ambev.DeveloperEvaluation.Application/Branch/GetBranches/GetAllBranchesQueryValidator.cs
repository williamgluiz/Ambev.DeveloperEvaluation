using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranches
{
    /// <summary>
    /// Validator for GetAllBranchesCommand.
    /// </summary>
    /// <remarks>
    /// This validator is primarily used for consistency in the command structure, 
    /// even though GetAllBranchesCommand does not require any specific rules.
    /// </remarks>
    public class GetAllBranchesQueryValidator : AbstractValidator<GetAllBranchesQuery>
    {
        /// <summary>
        /// Initializes a new instance of the GetAllBranchesCommandValidator.
        /// </summary>
        /// <remarks>
        /// Validation rules may be added in future if needed.
        /// </remarks>
        public GetAllBranchesQueryValidator()
        {
        }
    }
}
