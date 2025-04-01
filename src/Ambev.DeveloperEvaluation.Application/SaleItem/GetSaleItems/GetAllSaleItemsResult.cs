using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems
{
    /// <summary>
    /// Response returned after successfully retrieving all sale items.
    /// </summary>
    /// <remarks>
    /// This response contains a list of sale items, 
    /// where each sale item includes its ID, SaleItemId, Quantity, and UnitPrice.
    /// </remarks>
    public class GetAllSaleItemsResult
    {
        /// <summary>
        /// The total count of sale items available
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the list of sale items.
        /// </summary>
        public IEnumerable<SaleItemResult> SaleItems { get; set; } = new List<SaleItemResult>();
    }

    /// <summary>
    /// Represents details of a single sale item in the GetAllSaleItemsResponse.
    /// </summary>
    public class SaleItemResult
    {
        /// <summary>
        /// The unique identifier of the sale item
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identifier of the sale this item belongs to
        /// </summary>
        public Guid SaleId { get; set; }

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
