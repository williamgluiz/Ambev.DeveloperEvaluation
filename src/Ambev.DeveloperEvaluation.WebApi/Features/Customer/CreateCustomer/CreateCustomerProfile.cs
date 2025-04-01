using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.CreateCustomer
{
    /// <summary>
    /// Profile for mapping CreateCustomer feature requests and responses
    /// </summary>
    public class CreateCustomerProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateCustomer feature
        /// </summary>
        public CreateCustomerProfile()
        {
            CreateMap<CreateCustomerRequest, Application.Customer.CreateCustomer.CreateCustomerCommand>();
            CreateMap<Application.Customer.CreateCustomer.CreateCustomerResult, CreateCustomerResponse>();
        }
    }
}
