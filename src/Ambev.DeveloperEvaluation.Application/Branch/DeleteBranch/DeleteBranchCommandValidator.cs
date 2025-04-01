using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branch.DeleteBranch
{
    /// <summary>
    /// Validator for DeleteBranchCommand that defines validation rules for branch deletion.
    /// </summary>
    public class DeleteBranchCommandValidator : AbstractValidator<DeleteBranchCommand>
    {
        /// <summary>
        /// Initializes a new instance of the DeleteBranchCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ID: Must be a valid GUID and not empty.
        /// </remarks>
        public DeleteBranchCommandValidator()
        {
            RuleFor(command => command.Id)
                .NotEmpty().WithMessage("Branch ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Branch ID cannot be an empty GUID.");
        }
    }
}
