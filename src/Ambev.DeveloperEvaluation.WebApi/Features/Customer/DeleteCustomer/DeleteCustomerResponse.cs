namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.DeleteCustomer
{
    /// <summary>
    /// API response model for deleting a customer
    /// </summary>
    public class DeleteCustomerResponse
    {
        /// <summary>
        /// Indicates whether the deletion was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// A message providing additional information about the operation
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
