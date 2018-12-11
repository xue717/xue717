using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UInstallB
    {
        public UInstallB()
        {
            UInstallSub = new HashSet<UInstallSub>();
        }

        public int Id { get; set; }
        public int SeqId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public int? OrderId { get; set; }

        public virtual UInstall IdNavigation { get; set; }
        public virtual ICollection<UInstallSub> UInstallSub { get; set; }
    }
}
