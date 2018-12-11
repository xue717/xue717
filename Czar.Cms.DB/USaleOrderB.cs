using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class USaleOrderB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal? DeliveryQty { get; set; }
        public string Memo { get; set; }
        public DateTime? ExpectDate { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxUnitPrice { get; set; }
        public decimal? Tax { get; set; }

        public virtual USaleOrder IdNavigation { get; set; }
        public virtual UProduct Product { get; set; }
    }
}
