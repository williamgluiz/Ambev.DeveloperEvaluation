using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Product entities.
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
        /// <summary>
        /// Retrieves a Product by its external ID.
        /// </summary>
        /// <param name="externalId">The external ID of the Product.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>The Product associated with the external ID, or null if not found.</returns>
        Task<Product?> GetByExternalIdAsync(string externalId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a Product by its unique name.
        /// </summary>
        /// <param name="name">The name of the Product.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>The Product entity if found, otherwise null.</returns>
        Task<Product?> GetByNameAsync(string name, CancellationToken cancellationToken);
    }
}
