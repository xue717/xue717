using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UAccount
    {
        public UAccount()
        {
            USettlement = new HashSet<USettlement>();
        }

        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public bool Effective { get; set; }
        public int CompanyId { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? LastTime { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual ICollection<USettlement> USettlement { get; set; }
    }
}
