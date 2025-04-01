using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.DeleteSaleItem
{
    /// <summary>
    /// Profile for mapping DeleteSaleItem feature requests to commands
    /// </summary>
    public class DeleteSaleItemProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteSaleItem feature
        /// </summary>
        public DeleteSaleItemProfile()
        {
            CreateMap<Guid, Application.SaleItem.DeleteSaleItem.DeleteSaleItemCommand>()
                .ConstructUsing(id => new Application.SaleItem.DeleteSaleItem.DeleteSaleItemCommand(id));
        }
    }
}
