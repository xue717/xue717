using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysRegist
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime RegistTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int SysUserId { get; set; }

        public virtual SysCompany IdNavigation { get; set; }
    }
}
