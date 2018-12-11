using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysProblemB
    {
        public int Id { get; set; }
        public string Seq { get; set; }
        public string RespContent { get; set; }
        public DateTime RespTime { get; set; }
        public int RespId { get; set; }

        public virtual SysProblem IdNavigation { get; set; }
    }
}
