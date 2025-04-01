using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.UpdateCustomer
{
    /// <summary>
    /// Profile for mapping UpdateCustomer feature requests to commands
    /// </summary>
    public class UpdateCustomerProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateCustomer feature
        /// </summary>
        public UpdateCustomerProfile()
        {
            CreateMap<UpdateCustomerRequest, Application.Customer.UpdateCustomer.UpdateCustomerCommand>();
            CreateMap<Application.Customer.UpdateCustomer.UpdateCustomerResult, UpdateCustomerResponse>();
        }
    }
}
