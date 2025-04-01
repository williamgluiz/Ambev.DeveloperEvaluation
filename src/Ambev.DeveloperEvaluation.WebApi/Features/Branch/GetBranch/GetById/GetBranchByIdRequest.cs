namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetById
{
    /// <summary>
    /// Request model for retrieving a branch by its ID
    /// </summary>
    public class GetBranchByIdRequest
    {
        /// <summary>
        /// The unique identifier of the branch to retrieve
        /// </summary>
        public Guid Id { get; set; }
    }
}
