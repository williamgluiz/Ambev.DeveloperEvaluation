using Ambev.DeveloperEvaluation.Application.Product.CreateProduct;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.CreateSaleItem
{
    /// <summary>
    /// Profile for mapping between SaleItem entity and CreateSaleItemResult.
    /// </summary>
    public class CreateSaleItemProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateSaleItem operation.
        /// </summary>
        public CreateSaleItemProfile()
        {
            CreateMap<CreateSaleItemCommand, Domain.Entities.SaleItem>();
            CreateMap<Domain.Entities.SaleItem, CreateSaleItemResult>();
        }
    }
}
