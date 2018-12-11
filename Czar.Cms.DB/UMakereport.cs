using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UMakereport
    {
        public UMakereport()
        {
            UMakereportB = new HashSet<UMakereportB>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public int BillState { get; set; }
        public int DeptId { get; set; }
        public decimal Amount { get; set; }
        public string Memo { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public DateTime? CheckTime { get; set; }
        public int? CheckId { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<UMakereportB> UMakereportB { get; set; }
    }
}
