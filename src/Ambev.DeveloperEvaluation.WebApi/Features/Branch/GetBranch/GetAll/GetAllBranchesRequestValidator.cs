using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetAll
{
    /// <summary>
    /// Validator for GetAllBranchesRequest
    /// </summary>
    public class GetAllBranchesRequestValidator : AbstractValidator<GetAllBranchesRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetAllBranchesRequest
        /// </summary>
        public GetAllBranchesRequestValidator()
        {
            RuleFor(request => request.Take)
                .GreaterThan(0).WithMessage("Take must be greater than zero.")
                .LessThanOrEqualTo(100).WithMessage("Take must not exceed 100 records.");

            RuleFor(request => request.Skip)
                .GreaterThanOrEqualTo(0).WithMessage("Skip must be zero or greater.");
        }
    }
}
