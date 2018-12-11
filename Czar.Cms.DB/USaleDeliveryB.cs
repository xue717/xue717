using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class USaleDeliveryB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int ProducctId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal? SettlementQty { get; set; }
        public decimal? CostPrice { get; set; }
        public DateTime? ExpectDate { get; set; }
        public string Memo { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxUnitPrice { get; set; }
        public decimal? Tax { get; set; }

        public virtual USaleDelivery IdNavigation { get; set; }
    }
}
