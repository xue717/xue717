using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UExpensecost
    {
        public UExpensecost()
        {
            UExpensecostB = new HashSet<UExpensecostB>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int BillType { get; set; }
        public int BillState { get; set; }
        public int? BookType { get; set; }
        public int? AccountId { get; set; }
        public decimal Amount { get; set; }
        public int UnitId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public string Memo { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }

        public virtual ICollection<UExpensecostB> UExpensecostB { get; set; }
    }
}
