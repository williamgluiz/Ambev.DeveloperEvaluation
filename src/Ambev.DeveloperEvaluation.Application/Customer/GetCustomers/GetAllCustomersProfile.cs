using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomers
{
    /// <summary>
    /// Profile for mapping between Customer entity and GetAllCustomersResult.
    /// </summary>
    public class GetAllCustomersProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllCustomers operation.
        /// </summary>
        public GetAllCustomersProfile()
        {
            CreateMap<Domain.Entities.Customer, CustomerResult>();
        }
    }
}
