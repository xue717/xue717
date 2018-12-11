using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UMatreckonB
    {
        public int Id { get; set; }
        public int SeqId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public int BomId { get; set; }

        public virtual UMatreckon IdNavigation { get; set; }
    }
}
