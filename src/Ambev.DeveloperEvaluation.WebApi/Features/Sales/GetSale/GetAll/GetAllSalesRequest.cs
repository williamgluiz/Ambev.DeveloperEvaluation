namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetAll
{
    /// <summary>
    /// Request model for retrieving all sales
    /// </summary>
    public class GetAllSalesRequest
    {
        /// <summary>
        /// The optional search term to filter sales
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// The number of records to skip (for pagination)
        /// </summary>
        public int Skip { get; set; } = 0;

        /// <summary>
        /// The number of records to take (for pagination)
        /// </summary>
        public int Take { get; set; } = 10;
    }
}
