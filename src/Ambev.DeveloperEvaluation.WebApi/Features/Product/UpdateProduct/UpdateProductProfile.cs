using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.UpdateProduct
{
    /// <summary>
    /// Profile for mapping UpdateProduct feature requests to commands
    /// </summary>
    public class UpdateProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateProduct feature
        /// </summary>
        public UpdateProductProfile()
        {
            CreateMap<UpdateProductRequest, Application.Product.UpdateProduct.UpdateProductCommand>();
            CreateMap<Application.Product.UpdateProduct.UpdateProductResult, UpdateProductResponse>();
        }
    }
}
