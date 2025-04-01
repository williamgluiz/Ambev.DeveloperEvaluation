using Ambev.DeveloperEvaluation.Application.Product.GetProducts;
using MediatR;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetAll
{
    /// <summary>
    /// Query for retrieving all Products with optional filtering and pagination
    /// </summary>
    public class GetAllProductsQuery : IRequest<GetAllProductsResult>
    {
        /// <summary>
        /// Optional search term to filter Products
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
