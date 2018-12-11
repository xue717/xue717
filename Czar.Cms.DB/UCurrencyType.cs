using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UCurrencyType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public decimal Parities { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }
        public bool IsDefault { get; set; }
        public bool Effective { get; set; }
    }
}
