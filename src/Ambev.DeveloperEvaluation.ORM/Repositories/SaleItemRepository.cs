using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Repository implementation for SaleItem entity.
    /// </summary>
    public class SaleItemRepository : Repository<SaleItem>, ISaleItemRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Constructor for SaleItemRepository.
        /// </summary>
        /// <param name="context">DbContext instance.</param>
        public SaleItemRepository(DefaultContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves sale items by sale ID.
        /// </summary>
        /// <param name="saleId">The ID of the sale.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A list of sale items associated with the specified sale.</returns>
        public async Task<IEnumerable<SaleItem>> GetItemsBySaleIdAsync(Guid saleId, CancellationToken cancellationToken = default)
        {
            return await _context.Set<SaleItem>()
                .Where(si => si.SaleId == saleId)
                .ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Retrieves sale items by SaleItem ID.
        /// </summary>
        /// <param name="id">The ID of the SaleItem.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A list of sale items associated with the specified SaleItem.</returns>
        public async Task<IEnumerable<SaleItem>> GetItemsBySaleItemIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Set<SaleItem>()
                .Where(si => si.Id == id)
                .ToListAsync(cancellationToken);
        }
    }
}
