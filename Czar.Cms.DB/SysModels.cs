using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysModels
    {
        public SysModels()
        {
            SysRoleRights = new HashSet<SysRoleRights>();
        }

        public int Id { get; set; }
        public string ModelName { get; set; }
        public int ParentId { get; set; }
        public int Type { get; set; }
        public string Url { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public bool Effective { get; set; }
        public string ModelCode { get; set; }
        public int OrderId { get; set; }

        public virtual ICollection<SysRoleRights> SysRoleRights { get; set; }
    }
}
