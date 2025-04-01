using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Repository implementation for the <see cref="Product"/> entity.
    /// </summary>
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="context">The DbContext instance.</param>
        public ProductRepository(DefaultContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a product by its external ID.
        /// </summary>
        /// <param name="externalId">The external identifier of the product.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>
        /// The product associated with the given external ID, or <c>null</c> if not found.
        /// </returns>
        public async Task<Product?> GetByExternalIdAsync(string externalId, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Product>()
                .FirstOrDefaultAsync(p => p.ExternalId == externalId, cancellationToken);
        }

        /// <summary>
        /// Retrieves a product by its name.
        /// </summary>
        /// <param name="name">The name of the product to search for.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>
        /// The product that matches the specified name, or <c>null</c> if not found.
        /// </returns>
        public async Task<Product?> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _context.Set<Product>()
                .FirstOrDefaultAsync(p => p.Name == name, cancellationToken);
        }
    }
}
