using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Repository implementation for the <see cref="Sale"/> entity.
    /// </summary>
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRepository"/> class.
        /// </summary>
        /// <param name="context">The database context instance.</param>
        public SaleRepository(DefaultContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all sales associated with a specific customer.
        /// </summary>
        /// <param name="customerId">The unique identifier of the customer.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>A list of <see cref="Sale"/> entities linked to the specified customer.</returns>
        public async Task<IEnumerable<Sale>> GetSalesByCustomerIdAsync(Guid customerId, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Sale>()
                .Where(s => s.CustomerId == customerId)
                .ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Retrieves all sales associated with a specific branch.
        /// </summary>
        /// <param name="branchId">The unique identifier of the branch.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>A list of <see cref="Sale"/> entities linked to the specified branch.</returns>
        public async Task<IEnumerable<Sale>> GetSalesByBranchIdAsync(Guid branchId, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Sale>()
                .Where(s => s.BranchId == branchId)
                .ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Retrieves a sale by its ID, including its associated sale items.
        /// </summary>
        /// <param name="id">The unique identifier of the sale.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>The <see cref="Sale"/> entity with its related items, or <c>null</c> if not found.</returns>
        public async Task<Sale?> GetByIdWithItemsAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Sale>()
                .Include(s => s.Items)
                .FirstOrDefaultAsync(s => s.Id == id, cancellationToken);
        }

        /// <summary>
        /// Retrieves all sales, including their associated sale items.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>A list of all <see cref="Sale"/> entities, each including its related items.</returns>
        public async Task<IEnumerable<Sale>> GetAllSalesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Set<Sale>()
                .Include(s => s.Items)
                .ToListAsync(cancellationToken);
        }
    }
}
