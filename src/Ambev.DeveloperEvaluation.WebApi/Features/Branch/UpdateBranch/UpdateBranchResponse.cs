namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.UpdateBranch
{
    /// <summary>
    /// API response model for updating an existing branch
    /// </summary>
    public class UpdateBranchResponse
    {
        /// <summary>
        /// The unique identifier of the updated branch
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
