namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetById
{
    /// <summary>
    /// Request for retrieving a sale by its unique identifier
    /// </summary>
    public class GetSaleByIdRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale
        /// </summary>
        public Guid Id { get; set; }
    }
}
