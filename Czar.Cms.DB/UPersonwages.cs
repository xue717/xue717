using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UPersonwages
    {
        public int Id { get; set; }
        public int FlowId { get; set; }
        public int DeptId { get; set; }
        public int ProcessId { get; set; }
        public int PersonId { get; set; }
        public DateTime ReportTime { get; set; }
        public int WagesType { get; set; }
        public decimal Price { get; set; }
        public decimal FinQuantity { get; set; }
        public int SourceType { get; set; }
        public DateTime CreateTime { get; set; }
        public int SourceSeqId { get; set; }
    }
}
