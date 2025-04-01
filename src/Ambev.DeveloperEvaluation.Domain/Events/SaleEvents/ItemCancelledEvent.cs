using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Events.SaleEvents
{
    public class ItemCancelledEvent
    {
        public Guid SaleId { get; set; }
        public Guid SaleItemId { get; set; }
        public string SaleItemName { get; set; }
        public DateTime CancelledDate { get; set; }
    }

}
