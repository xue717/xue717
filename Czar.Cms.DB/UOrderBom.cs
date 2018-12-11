using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UOrderBom
    {
        public UOrderBom()
        {
            UOrderBomB = new HashSet<UOrderBomB>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public int BillState { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public int? CustomerId { get; set; }
        public int? PersonId { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public string Memo { get; set; }
        public int ShopId { get; set; }
        public int CompanyId { get; set; }
        public int SourceId { get; set; }

        public virtual ICollection<UOrderBomB> UOrderBomB { get; set; }
    }
}
