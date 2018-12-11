using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UMessage
    {
        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }
        public string Contnet { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int Flag { get; set; }
        public int? MesgType { get; set; }
        public int PersonId { get; set; }

        public virtual ULoginUser Person { get; set; }
    }
}
