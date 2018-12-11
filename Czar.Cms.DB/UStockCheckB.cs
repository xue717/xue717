using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UStockCheckB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal BookQuantity { get; set; }
        public decimal BookAmount { get; set; }
        public decimal DuringQauntity { get; set; }
        public decimal DuringAmount { get; set; }
        public decimal DiffQuantity { get; set; }
        public decimal DiffAmount { get; set; }
        public string Remark { get; set; }
        public string SeqCode { get; set; }

        public virtual UStockCheck IdNavigation { get; set; }
    }
}
