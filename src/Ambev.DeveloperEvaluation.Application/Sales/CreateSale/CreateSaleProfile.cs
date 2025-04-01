using Ambev.DeveloperEvaluation.Application.Sales.GetSaleById;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Profile for mapping between Sale entity and CreateSaleResult.
    /// </summary>
    public class CreateSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateSale operation.
        /// </summary>
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleCommand, Sale>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items))
                .AfterMap((src, dest) => dest.CalculateTotal());

            CreateMap<SaleItemCommandModel, Domain.Entities.SaleItem>()
                .ConstructUsing(src => new Domain.Entities.SaleItem(Guid.Empty, src.ProductId, src.Quantity, src.UnitPrice));

            CreateMap<Domain.Entities.SaleItem, SaleItemResponseModel>();

            CreateMap<Sale, CreateSaleResult>();
        }
    }
}
