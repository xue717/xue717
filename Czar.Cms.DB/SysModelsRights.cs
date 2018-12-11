using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysModelsRights
    {
        public int Id { get; set; }
        public string ActionCode { get; set; }
        public string ActionName { get; set; }
        public int CreateiD { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Effective { get; set; }
    }
}
