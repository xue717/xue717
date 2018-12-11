using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UMatterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CompanyId { get; set; }
        public DateTime? ModifyTime { get; set; }
        public bool Effective { get; set; }
    }
}
