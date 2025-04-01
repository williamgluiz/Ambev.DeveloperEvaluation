using Ambev.DeveloperEvaluation.Application.Customer.GetCustomers;
using Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetAll;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems
{
    /// <summary>
    /// Profile for mapping GetAllCustomers feature requests and responses
    /// </summary>
    public class GetAllCustomersProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllCustomers feature
        /// </summary>
        public GetAllCustomersProfile()
        {
            CreateMap<GetAllCustomersRequest, GetAllCustomersQuery>();
            CreateMap<Application.Customer.GetCustomers.GetAllCustomersResult, GetAllCustomersResponse>();

            CreateMap<CustomerResult, CustomerSummaryResponseModel>();
        }
    }
}