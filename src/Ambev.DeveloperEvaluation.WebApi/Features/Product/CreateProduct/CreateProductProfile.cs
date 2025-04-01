using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.CreateProduct
{
    /// <summary>
    /// Profile for mapping CreateProduct feature requests and responses
    /// </summary>
    public class CreateProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateProduct feature
        /// </summary>
        public CreateProductProfile()
        {
            CreateMap<CreateProductRequest, Application.Product.CreateProduct.CreateProductCommand>();
            CreateMap<Application.Product.CreateProduct.CreateProductResult, CreateProductResponse>();
        }
    }
}
