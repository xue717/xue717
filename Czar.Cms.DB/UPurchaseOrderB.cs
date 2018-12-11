using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UPurchaseOrderB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal? StockInQty { get; set; }
        public string Memo { get; set; }

        public virtual UPurchaseOrder IdNavigation { get; set; }
        public virtual UProduct Product { get; set; }
    }
}
