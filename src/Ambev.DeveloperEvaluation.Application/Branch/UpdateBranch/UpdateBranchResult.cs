namespace Ambev.DeveloperEvaluation.Application.Branch.UpdateBranch
{
    /// <summary>
    /// Response returned after updating a branch.
    /// </summary>
    /// <remarks>
    /// This response contains basic information about the update operation.
    /// </remarks>
    public class UpdateBranchResult
    {
        /// <summary>
        /// Indicates if the update was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides additional details about the update result.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the updated branch
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The updated name of the branch
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The updated external identifier for the branch
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// The updated denormalized description of the branch
        /// </summary>
        public string Description { get; set; } = string.Empty;

    }
}
