using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysUser
    {
        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string PassWord { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsSystem { get; set; }
        public bool Effective { get; set; }
        public string UserImg { get; set; }
    }
}
