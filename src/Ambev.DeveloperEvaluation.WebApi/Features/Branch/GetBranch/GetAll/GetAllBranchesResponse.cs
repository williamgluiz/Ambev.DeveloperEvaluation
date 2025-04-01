namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetAll
{
    /// <summary>
    /// API response model for retrieving all branches
    /// </summary>
    public class GetAllBranchesResponse
    {
        /// <summary>
        /// The total count of branches available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// The list of branches retrieved
        /// </summary>
        public List<BranchSummaryResponseModel> Branches { get; set; } = new();
    }

    /// <summary>
    /// Represents the summary details of a branch in the response
    /// </summary>
    public class BranchSummaryResponseModel
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
