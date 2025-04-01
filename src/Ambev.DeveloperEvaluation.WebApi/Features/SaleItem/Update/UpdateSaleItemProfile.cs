using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.Update
{
    /// <summary>
    /// Profile for mapping UpdateSaleItem feature requests to commands
    /// </summary>
    public class UpdateSaleItemProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateSaleItem feature
        /// </summary>
        public UpdateSaleItemProfile()
        {
            CreateMap<UpdateSaleItemRequest, Application.SaleItem.UpdateSaleItem.UpdateSaleItemCommand>();
            CreateMap<Application.SaleItem.UpdateSaleItem.UpdateSaleItemResult, UpdateSaleItemResponse>();
        }
    }
}
