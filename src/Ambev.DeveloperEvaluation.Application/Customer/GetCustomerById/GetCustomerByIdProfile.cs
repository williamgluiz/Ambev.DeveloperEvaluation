using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomerById
{
    /// <summary>
    /// Profile for mapping between Customer entity and GetCustomerByIdResponse.
    /// </summary>
    public class GetCustomerByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetCustomerById operation.
        /// </summary>
        public GetCustomerByIdProfile()
        {
            CreateMap<Domain.Entities.Customer, GetCustomerByIdResult>();
        }
    }
}
