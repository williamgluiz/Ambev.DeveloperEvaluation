using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    /// <summary>
    /// Profile for mapping between Customer entity and UpdateCustomerResponse.
    /// </summary>
    public class UpdateCustomerProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateCustomer operation.
        /// </summary>
        public UpdateCustomerProfile()
        {
            CreateMap<Domain.Entities.Customer, UpdateCustomerResult>();
            CreateMap<UpdateCustomerCommand, Domain.Entities.Customer>();
        }
    }
}
