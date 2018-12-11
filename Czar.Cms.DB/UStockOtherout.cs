using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UStockOtherout
    {
        public UStockOtherout()
        {
            UStockOtheroutB = new HashSet<UStockOtheroutB>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int BillType { get; set; }
        public int BillState { get; set; }
        public int ProductCount { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int ShopId { get; set; }
        public int? DeptId { get; set; }
        public string Memo { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }

        public virtual UShop Shop { get; set; }
        public virtual ICollection<UStockOtheroutB> UStockOtheroutB { get; set; }
    }
}
