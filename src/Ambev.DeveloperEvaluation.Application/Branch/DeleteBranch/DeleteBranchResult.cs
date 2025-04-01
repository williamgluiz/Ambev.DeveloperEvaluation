namespace Ambev.DeveloperEvaluation.Application.Branch.DeleteBranch
{
    /// <summary>
    /// Response returned after deleting a branch.
    /// </summary>
    /// <remarks>
    /// This response indicates whether the deletion was successful and provides
    /// a message with additional details.
    /// </remarks>
    public class DeleteBranchResult
    {
        /// <summary>
        /// Indicates if the deletion was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides additional details about the deletion result.
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
