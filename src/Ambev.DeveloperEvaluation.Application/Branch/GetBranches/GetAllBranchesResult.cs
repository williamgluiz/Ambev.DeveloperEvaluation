namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranches
{
    /// <summary>
    /// Response returned after successfully retrieving all branches.
    /// </summary>
    /// <remarks>
    /// This response contains a list of branches, 
    /// where each branch includes its ID, name, external ID, and description.
    /// </remarks>
    public class GetAllBranchesResult
    {
        /// <summary>
        /// The total count of branches available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the list of branches.
        /// </summary>
        public IEnumerable<BranchResult> Branches { get; set; } = new List<BranchResult>();
    }

    /// <summary>
    /// Represents details of a single branch in the GetAllBranchesResponse.
    /// </summary>
    public class BranchResult
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
