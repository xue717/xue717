using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysProblem
    {
        public SysProblem()
        {
            SysProblemB = new HashSet<SysProblemB>();
            SysProblemUrl = new HashSet<SysProblemUrl>();
        }

        public int Id { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int ProType { get; set; }
        public int ProState { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<SysProblemB> SysProblemB { get; set; }
        public virtual ICollection<SysProblemUrl> SysProblemUrl { get; set; }
    }
}
