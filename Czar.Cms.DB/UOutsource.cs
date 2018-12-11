using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UOutsource
    {
        public UOutsource()
        {
            UOutsourceAttachments = new HashSet<UOutsourceAttachments>();
            UOutsourceB = new HashSet<UOutsourceB>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int BillType { get; set; }
        public int BillState { get; set; }
        public decimal Amount { get; set; }
        public decimal? SettlementAmount { get; set; }
        public int VendorId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreteId { get; set; }
        public string Memo { get; set; }
        public int? CheckId { get; set; }
        public DateTime? ChecTime { get; set; }

        public virtual ICollection<UOutsourceAttachments> UOutsourceAttachments { get; set; }
        public virtual ICollection<UOutsourceB> UOutsourceB { get; set; }
    }
}
