using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Repository implementation for the <see cref="Customer"/> entity.
    /// </summary>
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
        /// </summary>
        /// <param name="context">The DbContext instance.</param>
        public CustomerRepository(DefaultContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a customer by their external ID.
        /// </summary>
        /// <param name="externalId">The external identifier of the customer.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>
        /// The customer associated with the given external ID, or <c>null</c> if not found.
        /// </returns>
        public async Task<Customer?> GetByExternalIdAsync(string externalId, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Customer>()
                .FirstOrDefaultAsync(c => c.ExternalId == externalId, cancellationToken);
        }

        /// <summary>
        /// Retrieves customers whose names contain the specified partial string.
        /// </summary>
        /// <param name="name">The partial name to search for.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>
        /// A collection of customers with names that match the given partial string.
        /// </returns>
        public async Task<IEnumerable<Customer>> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Customer>()
                .Where(c => c.Name.Contains(name))
                .ToListAsync(cancellationToken);
        }
    }
}
