using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for SaleItem entities.
    /// </summary>
    public interface ISaleItemRepository : IRepository<SaleItem>
    {
        /// <summary>
        /// Retrieves sale items by a specific sale ID.
        /// </summary>
        /// <param name="saleId">The ID of the sale.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>A list of sale items associated with the specified sale.</returns>
        Task<IEnumerable<SaleItem>> GetItemsBySaleIdAsync(Guid saleId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves sale items by a specific SaleItem ID.
        /// </summary>
        /// <param name="SaleItemId">The ID of the SaleItem.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>A list of sale items associated with the specified SaleItem.</returns>
        Task<IEnumerable<SaleItem>> GetItemsBySaleItemIdAsync(Guid SaleItemId, CancellationToken cancellationToken = default);
    }
}