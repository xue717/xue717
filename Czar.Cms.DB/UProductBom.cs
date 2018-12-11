using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProductBom
    {
        public UProductBom()
        {
            UProductBomB = new HashSet<UProductBomB>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public int BillState { get; set; }
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
        public int Ver { get; set; }

        public virtual ICollection<UProductBomB> UProductBomB { get; set; }
    }
}
