using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UQuoteB
    {
        public int Seq { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Spec { get; set; }
        public decimal Quantity { get; set; }
        public int UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public string Memo { get; set; }
        public decimal? TaxUnitPrice { get; set; }

        public virtual UQuote IdNavigation { get; set; }
    }
}
