using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UIncometype
    {
        public UIncometype()
        {
            UIncomeB = new HashSet<UIncomeB>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CompanyId { get; set; }
        public DateTime? ModifyTime { get; set; }
        public bool Effective { get; set; }

        public virtual ICollection<UIncomeB> UIncomeB { get; set; }
    }
}
