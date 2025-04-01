namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetById
{
    /// <summary>
    /// Request model for retrieving a customer by its ID
    /// </summary>
    public class GetCustomerByIdRequest
    {
        /// <summary>
        /// The unique identifier of the customer to retrieve
        /// </summary>
        public Guid Id { get; set; }
    }
}
