namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.DeleteCustomer
{
    /// <summary>
    /// Request model for deleting a customer
    /// </summary>
    public class DeleteCustomerRequest
    {
        /// <summary>
        /// The unique identifier of the customer to delete
        /// </summary>
        public Guid Id { get; set; }
    }
}
