using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class USaleDelivery
    {
        public USaleDelivery()
        {
            USaleDeliveryB = new HashSet<USaleDeliveryB>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int BillType { get; set; }
        public int BillState { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }
        public int ProductCount { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal? SettlementAmount { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreteId { get; set; }
        public decimal Discount { get; set; }
        public decimal? DepositAmount { get; set; }
        public int ShopId { get; set; }
        public string Memo { get; set; }
        public string DeliverCode { get; set; }
        public int? KdId { get; set; }
        public string KdCode { get; set; }
        public decimal? LogisticsAmount { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public int? CustomerId { get; set; }
        public int? ReturnSourceId { get; set; }
        public decimal? ReturnAmount { get; set; }
        public int? SettlementType { get; set; }
        public int? AccountId { get; set; }
        public int? InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public decimal? TaxRate { get; set; }
        public int? CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal? Parities { get; set; }
        public int? PersonId { get; set; }
        public int? CustType { get; set; }

        public virtual ICollection<USaleDeliveryB> USaleDeliveryB { get; set; }
    }
}
