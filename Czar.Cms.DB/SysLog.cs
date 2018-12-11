using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysLog
    {
        public int Id { get; set; }
        public int OperationType { get; set; }
        public string LogContent { get; set; }
        public int? Operator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string HostAddress { get; set; }
        public string Action { get; set; }
    }
}
