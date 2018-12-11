using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysKuaidi
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public bool Effective { get; set; }
    }
}
