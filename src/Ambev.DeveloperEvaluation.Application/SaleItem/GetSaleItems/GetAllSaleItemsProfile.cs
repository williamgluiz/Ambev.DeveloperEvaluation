using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems
{
    /// <summary>
    /// Profile for mapping between SaleItem entity and SaleItemResponse.
    /// </summary>
    public class GetAllSaleItemsProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllSaleItems operation.
        /// </summary>
        public GetAllSaleItemsProfile()
        {
            CreateMap<Domain.Entities.SaleItem, SaleItemResult>();
        }
    }
}
