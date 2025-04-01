using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    /// <summary>
    /// Profile for mapping between Sale entity and SaleResponse.
    /// </summary>
    public class GetAllSalesProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllSales operation.
        /// </summary>
        public GetAllSalesProfile()
        {
            CreateMap<Domain.Entities.Sale, SaleResult>();
        }
    }
}
