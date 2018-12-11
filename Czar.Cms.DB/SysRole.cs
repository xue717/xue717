using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysRole
    {
        public SysRole()
        {
            SysRoleRights = new HashSet<SysRoleRights>();
            SysUserrole = new HashSet<SysUserrole>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateId { get; set; }
        public int CompanyId { get; set; }
        public bool Effective { get; set; }

        public virtual ICollection<SysRoleRights> SysRoleRights { get; set; }
        public virtual ICollection<SysUserrole> SysUserrole { get; set; }
    }
}
