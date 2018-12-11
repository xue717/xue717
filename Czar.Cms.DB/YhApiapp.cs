using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class YhApiapp
    {
        public Guid Id { get; set; }
        public string AppName { get; set; }
        public string AppSecret { get; set; }
        public int AppType { get; set; }
        public int OsType { get; set; }
    }
}
