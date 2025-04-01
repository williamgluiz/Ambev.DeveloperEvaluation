using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.UpdateSaleItem
{
    /// <summary>
    /// Profile for mapping between SaleItem entity and UpdateSaleItemResponse.
    /// </summary>
    public class UpdateSaleItemProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateSaleItem operation.
        /// </summary>
        public UpdateSaleItemProfile()
        {
            CreateMap<Domain.Entities.SaleItem, UpdateSaleItemResult>();
            CreateMap<UpdateSaleItemCommand, Domain.Entities.SaleItem>();
        }
    }
}
