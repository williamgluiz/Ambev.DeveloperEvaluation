using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.DeleteCustomer
{
    /// <summary>
    /// Profile for mapping DeleteCustomer feature requests to commands
    /// </summary>
    public class DeleteCustomerProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteCustomer feature
        /// </summary>
        public DeleteCustomerProfile()
        {
            CreateMap<Guid, Application.Customer.DeleteCustomer.DeleteCustomerCommand>()
                .ConstructUsing(id => new Application.Customer.DeleteCustomer.DeleteCustomerCommand(id));
        }
    }
}
