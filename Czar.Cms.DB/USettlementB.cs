using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class USettlementB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int SourceId { get; set; }
        public string SourceCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal? SettlementAmount { get; set; }

        public virtual USettlement IdNavigation { get; set; }
    }
}
