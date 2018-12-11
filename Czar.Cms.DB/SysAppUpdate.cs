using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysAppUpdate
    {
        public int Id { get; set; }
        public string AppVersion { get; set; }
        public string Remark { get; set; }
        public int CreateId { get; set; }
        public DateTime CraeteTime { get; set; }
        public int AppType { get; set; }
    }
}
