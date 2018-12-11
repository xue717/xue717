using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UQuote
    {
        public UQuote()
        {
            UQuoteB = new HashSet<UQuoteB>();
        }

        public int Id { get; set; }
        public int CustId { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public string Tel { get; set; }
        public decimal Amount { get; set; }
        public int BillState { get; set; }
        public string PostName { get; set; }
        public string ToFaxNum { get; set; }
        public int Type { get; set; }
        public string Contacts { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public int? InvoiceId { get; set; }
        public int? OrderId { get; set; }
        public int? CompanyId { get; set; }

        public virtual ICollection<UQuoteB> UQuoteB { get; set; }
    }
}
