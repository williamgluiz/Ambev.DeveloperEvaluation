namespace Ambev.DeveloperEvaluation.Application.Branch.CreateBranch
{
    /// <summary>
    /// Represents the response returned after successfully creating a new branch.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created branch,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class CreateBranchResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created branch.
        /// </summary>
        /// <value>A GUID that uniquely identifies the created branch in the system.</value>
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
