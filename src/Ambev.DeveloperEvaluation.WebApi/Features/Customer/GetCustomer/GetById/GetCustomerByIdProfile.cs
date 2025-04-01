using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetById
{
    /// <summary>
    /// Profile for mapping GetCustomerById feature requests and responses
    /// </summary>
    public class GetCustomerByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetCustomerById feature
        /// </summary>
        public GetCustomerByIdProfile()
        {
            CreateMap<GetCustomerByIdRequest, Application.Customer.GetCustomerById.GetCustomerByIdQuery>();
            CreateMap<Application.Customer.GetCustomerById.GetCustomerByIdResult, GetCustomerByIdResponse>();
        }
    }
}
