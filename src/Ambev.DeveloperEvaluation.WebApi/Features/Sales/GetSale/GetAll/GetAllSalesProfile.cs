using Ambev.DeveloperEvaluation.Application.Sales.GetSales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale.GetAll
{
    /// <summary>
    /// Profile for mapping GetSales feature requests to commands
    /// </summary>
    public class GetAllSalesProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSales feature
        /// </summary>
        public GetAllSalesProfile()
        {
            CreateMap<GetAllSalesRequest, GetAllSalesQuery>();
            CreateMap<GetAllSalesResult, GetAllSalesResponse>();

            CreateMap<SaleResult, SaleItemsResponseModel>();
        }
    }
}

