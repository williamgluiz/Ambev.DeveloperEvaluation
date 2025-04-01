using Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale
{
    /// <summary>
    /// Profile for mapping UpdateSale feature requests to commands
    /// </summary>
    public class UpdateSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateSale feature
        /// </summary>
        public UpdateSaleProfile()
        {
            CreateMap<UpdateSaleRequest, UpdateSaleCommand>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

            CreateMap<SaleItemUpdateRequestModel, SaleItemUpdateModel>()
                .ConstructUsing(src => new SaleItemUpdateModel(src.Id, src.ProductId,src.Quantity, src.UnitPrice));

            CreateMap<UpdateSaleResult, UpdateSaleResponse>();
        }
    }
}
