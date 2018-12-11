using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UIncomeB
    {
        public int Id { get; set; }
        public string SeqId { get; set; }
        public int IncomeTypeId { get; set; }
        public decimal Amount { get; set; }
        public decimal? SettlementAmount { get; set; }
        public string Remark { get; set; }

        public virtual UIncome IdNavigation { get; set; }
        public virtual UIncometype IncomeType { get; set; }
    }
}
