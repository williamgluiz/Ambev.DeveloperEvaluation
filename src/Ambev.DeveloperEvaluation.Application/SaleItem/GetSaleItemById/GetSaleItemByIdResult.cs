using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItemById
{
    /// <summary>
    /// Response returned after successfully retrieving a sale item by its unique identifier.
    /// </summary>
    /// <remarks>
    /// This response contains the details of the sale item retrieved, 
    /// including Quantity, and UnitPrice.
    /// </remarks>
    public class GetSaleItemByIdResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale item.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated sale.
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the SaleItem in the sale item.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the SaleItem in the sale item.
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
