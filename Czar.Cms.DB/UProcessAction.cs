using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProcessAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Effective { get; set; }
        public int? CompanyId { get; set; }
        public int? CreateId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
