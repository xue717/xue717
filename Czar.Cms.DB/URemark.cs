using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class URemark
    {
        public int Id { get; set; }
        public string Remark { get; set; }
        public DateTime CreatTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }
    }
}
