using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.CreateSaleItem
{
    /// <summary>
    /// Profile for mapping CreateSaleItem feature requests to commands
    /// </summary>
    public class CreateSaleItemProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateSaleItem feature
        /// </summary>
        public CreateSaleItemProfile()
        {
            CreateMap<CreateSaleItemRequest, Application.SaleItem.CreateSaleItem.CreateSaleItemCommand>();
            CreateMap<Application.SaleItem.CreateSaleItem.CreateSaleItemResult, CreateSaleItemResponse>();
        }
    }
}
