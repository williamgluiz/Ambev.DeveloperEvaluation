using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetById
{
    /// <summary>
    /// Profile for mapping GetSaleItemById feature requests and responses
    /// </summary>
    public class GetSaleItemByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSaleItemById feature
        /// </summary>
        public GetSaleItemByIdProfile()
        {
            CreateMap<GetSaleItemByIdRequest, Application.SaleItem.GetSaleItemById.GetSaleItemByIdCommand>();
            CreateMap<Application.SaleItem.GetSaleItemById.GetSaleItemByIdResult, GetSaleItemByIdResponse>();
        }
    }
}
