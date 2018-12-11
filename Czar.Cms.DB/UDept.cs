using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UDept
    {
        public UDept()
        {
            UPerson = new HashSet<UPerson>();
        }

        public int Id { get; set; }
        public string DeptName { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }
        public bool Effective { get; set; }
        public int? ParentId { get; set; }
        public string AllPid { get; set; }
        public int? IsProduction { get; set; }

        public virtual ICollection<UPerson> UPerson { get; set; }
    }
}
