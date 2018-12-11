using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UStockinB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int ProducctId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public int? UnitId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal? Weight { get; set; }
        public string Memo { get; set; }

        public virtual UStockin IdNavigation { get; set; }
    }
}
