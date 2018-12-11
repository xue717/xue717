using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UStockOtherinB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int ProductId { get; set; }
        public int? UnitId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }

        public virtual UStockOtherin IdNavigation { get; set; }
    }
}
