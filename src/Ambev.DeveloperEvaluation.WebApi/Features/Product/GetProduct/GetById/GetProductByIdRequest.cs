namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetById
{
    /// <summary>
    /// Request model for retrieving a Product by its ID
    /// </summary>
    public class GetProductByIdRequest
    {
        /// <summary>
        /// The unique identifier of the Product to retrieve
        /// </summary>
        public Guid Id { get; set; }
    }
}
