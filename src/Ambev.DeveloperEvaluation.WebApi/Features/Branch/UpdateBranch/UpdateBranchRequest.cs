namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.UpdateBranch
{
    /// <summary>
    /// Request model for updating an existing branch
    /// </summary>
    public class UpdateBranchRequest
    {
        /// <summary>
        /// The unique identifier of the branch to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The updated name of the branch
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The updated external identifier for the branch
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// The updated denormalized description of the branch
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
