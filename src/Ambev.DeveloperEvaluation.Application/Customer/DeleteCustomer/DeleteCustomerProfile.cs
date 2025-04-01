using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.DeleteCustomer
{
    /// <summary>
    /// Profile for mapping between Customer entity and DeleteCustomerResponse.
    /// </summary>
    public class DeleteCustomerProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteCustomer operation.
        /// </summary>
        public DeleteCustomerProfile()
        {
            CreateMap<Domain.Entities.Customer, DeleteCustomerResult>();
        }
    }
}
