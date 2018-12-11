using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProcessFlowB
    {
        public int Id { get; set; }
        public string SeqId { get; set; }
        public int OrderNumb { get; set; }
        public int ProcessId { get; set; }
        public decimal Quantity { get; set; }
        public decimal FinQuantity { get; set; }
        public string Memo { get; set; }
        public decimal? QuotationTime { get; set; }
        public decimal? ActualTime { get; set; }
        public string OperatorId { get; set; }
        public bool? CkWf { get; set; }
        public string Pid { get; set; }
        public string OwderId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Wfqty { get; set; }
    }
}
