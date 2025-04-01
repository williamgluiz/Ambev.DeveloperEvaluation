using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.DeleteSaleItem
{
    /// <summary>
    /// Profile for mapping between SaleItem entity and DeleteSaleItemResponse.
    /// </summary>
    public class DeleteSaleItemProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteSaleItem operation.
        /// </summary>
        public DeleteSaleItemProfile()
        {
            CreateMap<Domain.Entities.SaleItem, DeleteSaleItemResult>();
        }
    }
}
