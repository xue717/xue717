using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysRegister
    {
        public int Id { get; set; }
        public int State { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string UserCode { get; set; }
        public int Type { get; set; }
        public string OpenId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CompanyId { get; set; }
    }
}
