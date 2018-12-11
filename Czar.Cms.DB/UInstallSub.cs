using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UInstallSub
    {
        public int Id { get; set; }
        public int SeqId { get; set; }
        public int SubId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }

        public virtual UInstall IdNavigation { get; set; }
        public virtual UInstallB Seq { get; set; }
    }
}
