﻿using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UStockOtheroutB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }

        public virtual UStockOtherout IdNavigation { get; set; }
    }
}
