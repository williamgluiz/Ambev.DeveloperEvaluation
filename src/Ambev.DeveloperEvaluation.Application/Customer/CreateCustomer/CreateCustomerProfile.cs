﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.CreateCustomer
{
    /// <summary>
    /// Profile for mapping between Customer entity and CreateCustomerResult.
    /// </summary>
    public class CreateCustomerProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateCustomer operation.
        /// </summary>
        public CreateCustomerProfile()
        {
            CreateMap<CreateCustomerCommand, Domain.Entities.Customer>();
            CreateMap<Domain.Entities.Customer, CreateCustomerResult>();
        }
    }
}
