using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UNotice
    {
        public int Id { get; set; }
        public string Memo { get; set; }
        public int CompanyId { get; set; }
        public int CreteId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Effective { get; set; }
    }
}
