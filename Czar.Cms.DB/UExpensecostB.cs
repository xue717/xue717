using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UExpensecostB
    {
        public int Id { get; set; }
        public string SeqId { get; set; }
        public int ExpenseId { get; set; }
        public decimal Amount { get; set; }
        public decimal? SettlementAmount { get; set; }
        public string Remark { get; set; }

        public virtual UExpensecost IdNavigation { get; set; }
    }
}
