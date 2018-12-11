using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UStockCheck
    {
        public UStockCheck()
        {
            UStockCheckB = new HashSet<UStockCheckB>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime CheckBeginDate { get; set; }
        public DateTime CheckEndDate { get; set; }
        public int BillType { get; set; }
        public int BillState { get; set; }
        public int ProductCount { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreteId { get; set; }
        public int ShopId { get; set; }
        public string Memo { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }

        public virtual UShop Shop { get; set; }
        public virtual ICollection<UStockCheckB> UStockCheckB { get; set; }
    }
}
