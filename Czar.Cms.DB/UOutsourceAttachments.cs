using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UOutsourceAttachments
    {
        public int Id { get; set; }
        public string SeqId { get; set; }
        public string Name { get; set; }
        public string DownUrl { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int DownCount { get; set; }

        public virtual UOutsource IdNavigation { get; set; }
    }
}
