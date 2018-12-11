using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysParamVal
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public string Val { get; set; }
        public DateTime? ModfiyTime { get; set; }
        public int? ModifyId { get; set; }
        public int CompanyId { get; set; }

        public virtual SysParam P { get; set; }
    }
}
