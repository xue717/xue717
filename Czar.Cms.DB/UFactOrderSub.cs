using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UFactOrderSub
    {
        public int Id { get; set; }
        public string SeqId { get; set; }
        public string SubId { get; set; }
        public string FactCode { get; set; }
        public int? GoodsId { get; set; }
        public string GoodsCode { get; set; }
        public string GoodsName { get; set; }
        public string ToothName { get; set; }
        public decimal? ToothNumb { get; set; }
        public decimal? Qauntity { get; set; }
        public int? GoodState { get; set; }

        public virtual UFactOrderB Seq { get; set; }
    }
}
