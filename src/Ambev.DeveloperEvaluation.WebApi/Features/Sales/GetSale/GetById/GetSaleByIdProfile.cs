using Ambev.DeveloperEvaluation.Application.Sales.GetSaleById;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetById
{
    /// <summary>
    /// Profile for mapping GetSaleById feature requests to commands
    /// </summary>
    public class GetSaleByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSaleById feature
        /// </summary>
        public GetSaleByIdProfile()
        {
            CreateMap<Sale, GetSaleByIdResult>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

            CreateMap<Domain.Entities.SaleItem, SaleItemResponseModel>();

            // Aqui está o novo mapeamento!
            CreateMap<GetSaleByIdResult, GetSaleResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

            CreateMap<Ambev.DeveloperEvaluation.Application.Sales.GetSaleById.SaleItemResponseModel,
                      Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetById.SaleItemResponseModel>();

        }
    }
}
