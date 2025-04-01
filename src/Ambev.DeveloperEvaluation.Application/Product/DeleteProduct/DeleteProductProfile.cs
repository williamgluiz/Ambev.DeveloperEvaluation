using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Product.DeleteProduct
{
    /// <summary>
    /// Profile for mapping between Product entity and DeleteProductResponse.
    /// </summary>
    public class DeleteProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteProduct operation.
        /// </summary>
        public DeleteProductProfile()
        {
            CreateMap<Domain.Entities.Product, DeleteProductResult>();
        }
    }
}
