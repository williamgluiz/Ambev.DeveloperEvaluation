using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleItem.CreateSaleItem
{
    /// <summary>
    /// Response returned after successfully creating a new sale item.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created sale item,
    /// along with other relevant details.
    /// </remarks>
    public class CreateSaleItemResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created sale item.
        /// </summary>
        public Guid Id { get; set; }
    }
}
