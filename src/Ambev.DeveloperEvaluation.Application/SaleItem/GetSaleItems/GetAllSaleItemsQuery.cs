using Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems
{
    /// <summary>
    /// Query for retrieving all sale items with optional filtering and pagination
    /// </summary>
    public class GetAllSaleItemsQuery : IRequest<GetAllSaleItemsResult>
    {
        /// <summary>
        /// Optional filter by Sale ID
        /// </summary>
        public Guid? SaleId { get; set; }

        /// <summary>
        /// The number of records to skip (for pagination)
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// The number of records to take (for pagination)
        /// </summary>
        public int Take { get; set; }
    }
}
