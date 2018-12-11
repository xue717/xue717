using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysPowerVal
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public bool? Val { get; set; }
    }
}
