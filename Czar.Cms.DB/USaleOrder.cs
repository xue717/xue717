using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class USaleOrder
    {
        public USaleOrder()
        {
            USaleOrderB = new HashSet<USaleOrderB>();
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
        public string ExternalId { get; set; }
        public int? InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public decimal? TaxRate { get; set; }
        public int? CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal? Parities { get; set; }
        public int? PurchaseId { get; set; }
        public bool? IsSend { get; set; }
        public string Remarks { get; set; }
        public int? CustType { get; set; }
        public int? PersonId { get; set; }
        public string PostTime { get; set; }
        public bool? FreightParty { get; set; }
        public string SettlementWay { get; set; }

        public virtual SysCompany Company { get; set; }
        public virtual UShop Shop { get; set; }
        public virtual ICollection<USaleOrderB> USaleOrderB { get; set; }
    }
}
