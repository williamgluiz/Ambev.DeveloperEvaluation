using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProducts
{
    /// <summary>
    /// Profile for mapping between Product entity and GetAllProductsResponse.
    /// </summary>
    public class GetAllProductsProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllProducts operation.
        /// </summary>
        public GetAllProductsProfile()
        {
            CreateMap<Domain.Entities.Product, ProductResult>();
        }
    }
}
