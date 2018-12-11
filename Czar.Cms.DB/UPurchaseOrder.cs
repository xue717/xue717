using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UPurchaseOrder
    {
        public UPurchaseOrder()
        {
            UPurchaseOrderB = new HashSet<UPurchaseOrderB>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int BillType { get; set; }
        public int BillState { get; set; }
        public int? VendorId { get; set; }
        public string VendorName { get; set; }
        public string Tel { get; set; }
        public int ProductCount { get; set; }
        public decimal Quantity { get; set; }
        public decimal StockInQty { get; set; }
        public decimal Amount { get; set; }
        public decimal? SettlementAmount { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreteId { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal? DepositAmountOff { get; set; }
        public int ShopId { get; set; }
        public string ContractCode { get; set; }
        public DateTime? ExpectDate { get; set; }
        public string Memo { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public decimal? ReturnAmount { get; set; }

        public virtual SysCompany Company { get; set; }
        public virtual UShop Shop { get; set; }
        public virtual ICollection<UPurchaseOrderB> UPurchaseOrderB { get; set; }
    }
}
