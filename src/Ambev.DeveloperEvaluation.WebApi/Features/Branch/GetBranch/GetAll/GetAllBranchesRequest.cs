namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetAll
{
    /// <summary>
    /// Request model for retrieving all branches
    /// </summary>
    public class GetAllBranchesRequest
    {
        /// <summary>
        /// The optional search term to filter branches
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// The number of records to skip (for pagination)
        /// </summary>
        public int Skip { get; set; } = 0;

        /// <summary>
        /// The number of records to take (for pagination)
        /// </summary>
        public int Take { get; set; } = 10;
    }
}
