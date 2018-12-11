using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UStockin
    {
        public UStockin()
        {
            UStockinB = new HashSet<UStockinB>();
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
        public decimal? SettlementAmount { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreteId { get; set; }
        public int ShopId { get; set; }
        public string Memo { get; set; }
        public int? VendorId { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public int? ReturnSourceId { get; set; }
        public decimal? ReturnAmount { get; set; }
        public int? SettlementType { get; set; }
        public int? AccountId { get; set; }
        public bool? IsTax { get; set; }

        public virtual UShop Shop { get; set; }
        public virtual ICollection<UStockinB> UStockinB { get; set; }
    }
}
