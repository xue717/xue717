using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UOutsourceB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }
        public int ProcessId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal FinQuantity { get; set; }
        public bool FinState { get; set; }

        public virtual UOutsource IdNavigation { get; set; }
    }
}
