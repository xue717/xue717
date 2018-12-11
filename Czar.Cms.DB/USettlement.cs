using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class USettlement
    {
        public USettlement()
        {
            USettlementB = new HashSet<USettlementB>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int BillType { get; set; }
        public int BillState { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreteId { get; set; }
        public string Memo { get; set; }
        public int? CheckId { get; set; }
        public DateTime? ChecTime { get; set; }

        public virtual UAccount Account { get; set; }
        public virtual ICollection<USettlementB> USettlementB { get; set; }
    }
}
