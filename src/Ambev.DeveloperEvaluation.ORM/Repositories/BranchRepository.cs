using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Repository implementation for the <see cref="Branch"/> entity.
    /// </summary>
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRepository"/> class.
        /// </summary>
        /// <param name="context">The DbContext instance.</param>
        public BranchRepository(DefaultContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a branch by its external ID.
        /// </summary>
        /// <param name="externalId">The external identifier of the branch.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>
        /// The branch associated with the given external ID, or <c>null</c> if not found.
        /// </returns>
        public async Task<Branch?> GetByExternalIdAsync(string externalId, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Branch>()
                .FirstOrDefaultAsync(b => b.ExternalId == externalId, cancellationToken);
        }

        /// <summary>
        /// Retrieves branches that contain the specified name.
        /// </summary>
        /// <param name="name">The partial name to search for.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>
        /// A collection of branches whose names contain the specified value.
        /// </returns>
        public async Task<IEnumerable<Branch>> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Branch>()
                .Where(b => b.Name.Contains(name))
                .ToListAsync(cancellationToken);
        }
    }
}
