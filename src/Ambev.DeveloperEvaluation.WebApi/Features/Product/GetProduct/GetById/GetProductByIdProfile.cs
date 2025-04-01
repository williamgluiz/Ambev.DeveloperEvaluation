using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetById
{
    /// <summary>
    /// Profile for mapping GetProductById feature requests and responses
    /// </summary>
    public class GetProductByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetProductById feature
        /// </summary>
        public GetProductByIdProfile()
        {
            CreateMap<GetProductByIdRequest, Application.Product.GetProductById.GetProductByIdQuery>();
            CreateMap<Application.Product.GetProductById.GetProductByIdResult, GetProductByIdResponse>();
        }
    }
}
