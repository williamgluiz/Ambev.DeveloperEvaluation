namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.DeleteBranch
{
    /// <summary>
    /// API response model for deleting a branch
    /// </summary>
    public class DeleteBranchResponse
    {
        /// <summary>
        /// Indicates whether the deletion was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// A message providing additional information about the operation
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
