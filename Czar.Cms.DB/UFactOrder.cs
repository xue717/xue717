using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UFactOrder
    {
        public UFactOrder()
        {
            UFactOrderAttachments = new HashSet<UFactOrderAttachments>();
            UFactOrderB = new HashSet<UFactOrderB>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int BillType { get; set; }
        public int BillState { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Tel { get; set; }
        public int ProductCount { get; set; }
        public decimal Quantity { get; set; }
        public decimal DeliveryQty { get; set; }
        public decimal Amount { get; set; }
        public decimal? SettlementAmount { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int? PersonId { get; set; }
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
        public string ExternalId { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }

        public virtual SysCompany Company { get; set; }
        public virtual UShop Shop { get; set; }
        public virtual ICollection<UFactOrderAttachments> UFactOrderAttachments { get; set; }
        public virtual ICollection<UFactOrderB> UFactOrderB { get; set; }
    }
}
