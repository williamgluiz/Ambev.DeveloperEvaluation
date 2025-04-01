using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItemById
{
    /// <summary>
    /// Profile for mapping between SaleItem entity and GetSaleItemByIdResponse.
    /// </summary>
    public class GetSaleItemByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSaleItemById operation.
        /// </summary>
        public GetSaleItemByIdProfile()
        {
            CreateMap<Domain.Entities.SaleItem, GetSaleItemByIdResult>();
        }
    }
}
