using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProcessFlowList
    {
        public int Id { get; set; }
        public string ListId { get; set; }
        public int OrderNumb { get; set; }
        public int? GoodsId { get; set; }
        public int ProcessId { get; set; }
        public DateTime? OperationStart { get; set; }
        public DateTime? OperationEnd { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal Quantity { get; set; }
        public decimal? FinQuantity { get; set; }
        public DateTime? CreateTime { get; set; }
        public int CreateId { get; set; }
        public int? OperatorId { get; set; }
        public bool FinState { get; set; }
        public decimal? BadQty { get; set; }
        public bool? StartState { get; set; }
        public string Memo { get; set; }

        public virtual UProcessFlow IdNavigation { get; set; }
    }
}
