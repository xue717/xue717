using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysCodeVal
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string BillName { get; set; }
        public string Prefix { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? ModifyId { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int CompanyId { get; set; }
    }
}
