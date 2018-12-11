using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UPickmaterialC
    {
        public int SeqId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public string ProFlowId { get; set; }
        public decimal NeedQuantity { get; set; }
        public decimal RealQuantity { get; set; }
        public decimal DiffQuantity { get; set; }
        public decimal DeliveryQty { get; set; }
        public string Memo { get; set; }
        public string ParentId { get; set; }
        public string OwnerId { get; set; }
        public bool? HaveSon { get; set; }
    }
}
