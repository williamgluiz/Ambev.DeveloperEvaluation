namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.CreateBranch
{
    /// <summary>
    /// Request model for creating a new branch
    /// </summary>
    public class CreateBranchRequest
    {
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
