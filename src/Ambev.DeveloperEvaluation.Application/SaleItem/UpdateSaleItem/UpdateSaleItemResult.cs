using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.UpdateSaleItem
{
    /// <summary>
    /// Response returned after successfully updating a sale item.
    /// </summary>
    /// <remarks>
    /// This response indicates whether the update was successful and provides
    /// additional details.
    /// </remarks>
    public class UpdateSaleItemResult
    {
        /// <summary>
        /// Indicates if the update was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides additional details about the update result.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the sale item
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Quantity sold of the SaleItem
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Unit price of the SaleItem
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Discount applied to the item
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Total amount of the item after applying the discount
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}
