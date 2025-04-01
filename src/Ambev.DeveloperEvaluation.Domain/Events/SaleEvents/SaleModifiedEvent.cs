using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Events.SaleEvents
{
    public class SaleModifiedEvent
    {
        public Guid SaleId { get; set; }
        public string SaleNumber { get; set; }
        public decimal UpdatedTotalAmount { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
