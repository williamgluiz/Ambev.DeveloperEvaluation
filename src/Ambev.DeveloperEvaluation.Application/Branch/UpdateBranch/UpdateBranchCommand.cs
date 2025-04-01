using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branch.UpdateBranch
{
    /// <summary>
    /// Command for updating an existing branch.
    /// </summary>
    /// <remarks>
    /// This command is used to capture the required data for updating a branch, 
    /// including its unique identifier, name, external ID, and description. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="UpdateBranchResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="UpdateBranchCommandValidator"/> which extends 
    /// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
    /// populated and follow the required rules.
    /// </remarks>
    public class UpdateBranchCommand : IRequest<UpdateBranchResult>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the branch to be updated.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the branch.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the external ID for the branch.
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the branch.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Validates the command using UpdateBranchCommandValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new UpdateBranchCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
