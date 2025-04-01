using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Branch entities.
    /// </summary>
    public interface IBranchRepository : IRepository<Branch>
    {
        /// <summary>
        /// Retrieves branches by name.
        /// </summary>
        /// <param name="name">The name of the SaleItem.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>The SaleItem associated with the name.</returns>
        Task<IEnumerable<Branch>> GetByNameAsync(string name, CancellationToken cancellationToken = default);
    }
}
