using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysPower
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? DeftVal { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
