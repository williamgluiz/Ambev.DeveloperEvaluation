namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranchById
{
    /// <summary>
    /// Response returned after successfully retrieving a branch by its unique identifier.
    /// </summary>
    /// <remarks>
    /// This response contains the details of the branch retrieved, 
    /// including its name, external ID, and description.
    /// </remarks>
    public class GetBranchByIdResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the branch.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the branch.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the external ID of the branch.
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the branch.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
