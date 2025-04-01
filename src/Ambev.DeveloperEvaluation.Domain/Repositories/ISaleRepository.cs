using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Sale entities.
    /// </summary>
    public interface ISaleRepository : IRepository<Sale>
    {
        /// <summary>
        /// Retrieves sales by customer ID.
        /// </summary>
        /// <param name="customerId">The customer ID of the sale.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>The sale associated with the customer ID.</returns>
        Task<IEnumerable<Sale>> GetSalesByCustomerIdAsync(Guid customerId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves sales by branch ID.
        /// </summary>
        /// <param name="branchId">The branch ID of the Sale.</param>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>The sale associated with the branch ID.</returns>
        Task<IEnumerable<Sale>> GetSalesByBranchIdAsync(Guid branchId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a sale by its ID, including its associated sale items.
        /// </summary>
        /// <param name="id">The unique identifier of the sale.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>The <see cref="Sale"/> entity with its related items, or <c>null</c> if not found.</returns>
        Task<Sale?> GetByIdWithItemsAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Retrieves all sales, including their associated sale items.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>A list of all <see cref="Sale"/> entities, each including its related items.</returns>
        Task<IEnumerable<Sale>> GetAllSalesAsync(CancellationToken cancellationToken);

    }
}

