using Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetAll
{
    /// <summary>
    /// Profile for mapping GetAllSaleItems feature requests and responses
    /// </summary>
    public class GetAllSaleItemsProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllSaleItems feature
        /// </summary>
        public GetAllSaleItemsProfile()
        {
            CreateMap<GetAllSaleItemsRequest, GetAllSaleItemsQuery>();
            CreateMap<GetAllSaleItemsResult, GetAllSaleItemsResponse>();
            CreateMap<SaleItemResult, SaleItemSummaryResponseModel>();
        }
    }
}
