using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Customer entities.
    /// </summary>
    public interface ICustomerRepository : IRepository<Customer>
    {
        /// <summary>
        /// Retrieves customers by a given external ID.
        /// </summary>
        /// <param name="externalId">The external ID of the customer.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>The customer associated with the external ID, or null if not found.</returns>
        Task<Customer?> GetByExternalIdAsync(string externalId, CancellationToken cancellationToken = default);
    }
}
