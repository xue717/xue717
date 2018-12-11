using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysRoleRights
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int RoleId { get; set; }
        public bool? Isbrowse { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsCheck { get; set; }
        public bool? IsPrint { get; set; }
        public bool? SeePrice { get; set; }
        public bool? SeeAmount { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateId { get; set; }

        public virtual SysModels Model { get; set; }
        public virtual SysRole Role { get; set; }
    }
}
