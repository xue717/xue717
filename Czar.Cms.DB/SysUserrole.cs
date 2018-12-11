using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysUserrole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime Createtime { get; set; }
        public int CreateId { get; set; }

        public virtual SysRole Role { get; set; }
        public virtual ULoginUser User { get; set; }
    }
}
