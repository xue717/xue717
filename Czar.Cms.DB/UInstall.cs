using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UInstall
    {
        public UInstall()
        {
            UInstallB = new HashSet<UInstallB>();
            UInstallSub = new HashSet<UInstallSub>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int BillState { get; set; }
        public DateTime BillDate { get; set; }
        public int ProductCount { get; set; }
        public decimal Quantity { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public int CompanyId { get; set; }
        public int ShopId { get; set; }
        public string Memo { get; set; }

        public virtual ICollection<UInstallB> UInstallB { get; set; }
        public virtual ICollection<UInstallSub> UInstallSub { get; set; }
    }
}
