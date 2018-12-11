using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UMakeperson
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public decimal Quantity { get; set; }
        public int SourceId { get; set; }
    }
}
