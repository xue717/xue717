using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysProblemUrl
    {
        public string Seq { get; set; }
        public string Url { get; set; }
        public DateTime CreatTime { get; set; }
        public int CareteId { get; set; }
        public int Id { get; set; }

        public virtual SysProblem IdNavigation { get; set; }
    }
}
