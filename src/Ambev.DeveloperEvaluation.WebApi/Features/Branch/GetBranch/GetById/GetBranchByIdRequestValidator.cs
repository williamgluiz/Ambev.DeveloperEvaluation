using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetById
{
    /// <summary>
    /// Validator for GetBranchByIdRequest
    /// </summary>
    public class GetBranchByIdRequestValidator : AbstractValidator<GetBranchByIdRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetBranchByIdRequest
        /// </summary>
        public GetBranchByIdRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("Branch ID must not be empty.");
        }
    }
}
