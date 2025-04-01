using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.DeleteCustomer
{
    /// <summary>
    /// Response returned after deleting a customer.
    /// </summary>
    /// <remarks>
    /// This response indicates whether the deletion was successful and provides
    /// a message with additional details.
    /// </remarks>
    public class DeleteCustomerResult
    {
        /// <summary>
        /// Indicates if the deletion was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides additional details about the deletion result.
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
