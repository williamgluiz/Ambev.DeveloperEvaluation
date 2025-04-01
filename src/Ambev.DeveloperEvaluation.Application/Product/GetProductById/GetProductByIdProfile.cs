using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProductById
{
    /// <summary>
    /// Profile for mapping between Product entity and GetProductByIdResponse.
    /// </summary>
    public class GetProductByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetProductById operation.
        /// </summary>
        public GetProductByIdProfile()
        {
            CreateMap<Domain.Entities.Product, GetProductByIdResult>();
        }
    }
}
