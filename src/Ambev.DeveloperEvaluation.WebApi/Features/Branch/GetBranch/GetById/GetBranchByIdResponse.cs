namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetById
{
    /// <summary>
    /// API response model for retrieving a branch by ID
    /// </summary>
    public class GetBranchByIdResponse
    {
        /// <summary>
        /// The unique identifier of the branch
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
