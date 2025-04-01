using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    /// <summary>
    /// Query for retrieving all sales with optional filtering and pagination
    /// </summary>
    public class GetAllSalesQuery : IRequest<GetAllSalesResult>
    {
        /// <summary>
        /// Optional search term to filter sales
        /// </summary>
        public string? SearchTerm { get; set; }

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
