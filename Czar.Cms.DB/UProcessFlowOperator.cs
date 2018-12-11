using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProcessFlowOperator
    {
        public int? Id { get; set; }
        public string ItemId { get; set; }
        public int? ActionId { get; set; }
        public int? OperatorId { get; set; }
        public DateTime? CreateTime { get; set; }
        public decimal? Quantity { get; set; }
        public int? ListId { get; set; }
        public decimal? BadQty { get; set; }

        public virtual UProcessFlow IdNavigation { get; set; }
    }
}
