namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.CreateBranch
{
    /// <summary>
    /// API response model for creating a new branch
    /// </summary>
    public class CreateBranchResponse
    {
        /// <summary>
        /// The unique identifier of the created branch
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the branch
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// External identity for referencing in other domains
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Denormalized description of the branch
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
