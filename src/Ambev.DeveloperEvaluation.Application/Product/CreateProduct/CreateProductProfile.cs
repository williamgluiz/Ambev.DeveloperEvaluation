using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.CreateProduct
{
    /// <summary>
    /// Profile for mapping between Product entity and CreateProductResult.
    /// </summary>
    public class CreateProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateProduct operation.
        /// </summary>
        public CreateProductProfile()
        {
            CreateMap<CreateProductCommand, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, CreateProductResult>();
        }
    }
}
