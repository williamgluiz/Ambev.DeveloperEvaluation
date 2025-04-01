using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Product.UpdateProduct
{
    /// <summary>
    /// Profile for mapping between Product entity and UpdateProductResponse.
    /// </summary>
    public class UpdateProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateProduct operation.
        /// </summary>
        public UpdateProductProfile()
        {
            CreateMap<Domain.Entities.Product, UpdateProductResult>();
            CreateMap<UpdateProductCommand, Domain.Entities.Product>();
        }
    }
}
