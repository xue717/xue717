using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UFactOrderB
    {
        public UFactOrderB()
        {
            UFactOrderSub = new HashSet<UFactOrderSub>();
        }

        public int Id { get; set; }
        public string SeqId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Unitprice { get; set; }
        public decimal? Amount { get; set; }
        public string SpecifiCation { get; set; }
        public int? UnitId { get; set; }
        public string FactCode { get; set; }
        public DateTime? ExpectDate { get; set; }
        public string Memo { get; set; }
        public string SeparateNum { get; set; }

        public virtual UFactOrder IdNavigation { get; set; }
        public virtual ICollection<UFactOrderSub> UFactOrderSub { get; set; }
    }
}
