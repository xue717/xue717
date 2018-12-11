using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProductClass
    {
        public UProductClass()
        {
            UProduct = new HashSet<UProduct>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }
        public string Memo { get; set; }
        public DateTime CreatTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }
        public bool Effective { get; set; }
        public int? ParentId { get; set; }
        public string AllPid { get; set; }
        public string Code { get; set; }
        public bool? IsOutSource { get; set; }

        public virtual ICollection<UProduct> UProduct { get; set; }
    }
}
