using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.DeleteProduct
{
    /// <summary>
    /// Profile for mapping DeleteProduct feature requests to commands
    /// </summary>
    public class DeleteProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteProduct feature
        /// </summary>
        public DeleteProductProfile()
        {
            CreateMap<Guid, Application.Product.DeleteProduct.DeleteProductCommand>()
                .ConstructUsing(id => new Application.Product.DeleteProduct.DeleteProductCommand(id));
        }
    }
}
