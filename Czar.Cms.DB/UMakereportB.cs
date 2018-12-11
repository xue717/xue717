using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UMakereportB
    {
        public int Id { get; set; }
        public int SeqId { get; set; }
        public int OrderNumb { get; set; }
        public int FactId { get; set; }
        public int ProductId { get; set; }
        public int ProcessId { get; set; }
        public int WagesType { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal? FinQuantity { get; set; }
        public string Memo { get; set; }
        public int FlowId { get; set; }

        public virtual UMakereport IdNavigation { get; set; }
    }
}
