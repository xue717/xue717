using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UMatreckon
    {
        public UMatreckon()
        {
            UMatreckonB = new HashSet<UMatreckonB>();
            UMatreckonSub = new HashSet<UMatreckonSub>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int BillState { get; set; }
        public int ProductCount { get; set; }
        public decimal Quantity { get; set; }
        public int CompanyId { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public int? ModifyId { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual ICollection<UMatreckonB> UMatreckonB { get; set; }
        public virtual ICollection<UMatreckonSub> UMatreckonSub { get; set; }
    }
}
