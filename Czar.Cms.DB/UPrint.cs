using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UPrint
    {
        public int Id { get; set; }
        public string PrintCode { get; set; }
        public int? ModelCode { get; set; }
        public string PrintName { get; set; }
        public string Url { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateId { get; set; }
        public bool? Effective { get; set; }
        public int? CompanyId { get; set; }
    }
}
