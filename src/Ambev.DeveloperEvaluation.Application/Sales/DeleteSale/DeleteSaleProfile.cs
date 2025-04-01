using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale
{
    /// <summary>
    /// Profile for mapping between Sale entity and DeleteSaleResponse.
    /// </summary>
    public class DeleteSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteSale operation.
        /// </summary>
        public DeleteSaleProfile()
        {
            CreateMap<Domain.Entities.Sale, DeleteSaleResult>();
        }
    }
}
