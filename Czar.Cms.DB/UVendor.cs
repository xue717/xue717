using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UVendor
    {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string VendorCode { get; set; }
        public string Telephone { get; set; }
        public string Memo { get; set; }
        public int ClassId { get; set; }
        public string Address { get; set; }
        public decimal? AccAmount { get; set; }
        public decimal? ReceAmount { get; set; }
        public decimal? AdvAmount { get; set; }
        public int? SingleCount { get; set; }
        public DateTime? LastSingleTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public int CreateId { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int CompanyId { get; set; }
        public bool Effective { get; set; }
        public string ContactName { get; set; }
        public string FaxName { get; set; }

        public virtual UVendorClass Class { get; set; }
    }
}
