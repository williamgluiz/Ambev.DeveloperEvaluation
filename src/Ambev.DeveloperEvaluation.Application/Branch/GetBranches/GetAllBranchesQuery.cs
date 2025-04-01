using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranches
{
    /// <summary>
    /// Query for retrieving all branches with optional filtering and pagination
    /// </summary>
    public class GetAllBranchesQuery : IRequest<GetAllBranchesResult>
    {
        /// <summary>
        /// Optional search term to filter branches
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// The number of records to skip (for pagination)
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// The number of records to take (for pagination)
        /// </summary>
        public int Take { get; set; }
    }
}
