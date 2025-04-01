namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetAll
{
    /// <summary>
    /// Request model for retrieving all sale items
    /// </summary>
    public class GetAllSaleItemsRequest
    {
        /// <summary>
        /// Optional filter by Sale ID
        /// </summary>
        public Guid? SaleId { get; set; }

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
