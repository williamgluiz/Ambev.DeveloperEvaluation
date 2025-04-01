using Ambev.DeveloperEvaluation.Application.Product.GetProducts;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetAll
{
    /// <summary>
    /// Profile for mapping GetAllProducts feature requests and responses
    /// </summary>
    public class GetAllProductsProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllProducts feature
        /// </summary>
        public GetAllProductsProfile()
        {
            CreateMap<GetAllProductsRequest, GetAllProductsQuery>();
            CreateMap<Application.Product.GetProducts.GetAllProductsResult, GetAllProductsResponse>();
            CreateMap<ProductResult, ProductSummaryResponseModel>();
        }
    }
}
