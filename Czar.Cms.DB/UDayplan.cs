using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UDayplan
    {
        public int Id { get; set; }
        public int FactId { get; set; }
        public DateTime PlanDate { get; set; }
        public decimal Quantity { get; set; }
        public int ProcessId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public string FactCode { get; set; }
    }
}
