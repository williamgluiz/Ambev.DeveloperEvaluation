using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// Profile for mapping between Application and API CreateSale responses
    /// </summary>
    public class CreateSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateSale feature
        /// </summary>
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleRequest, Application.Sales.CreateSale.CreateSaleCommand>();

            CreateMap<Application.Sales.CreateSale.CreateSaleResult, CreateSaleResponse>();

            CreateMap<SaleItemRequestModel, SaleItemCommandModel>()
                .ReverseMap();


            CreateMap<Domain.Entities.Sale, CreateSaleResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

            CreateMap<Domain.Entities.SaleItem, SaleItemResponseModel>();
        }
    }
}
