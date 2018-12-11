using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProductCustom
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string CusTomName { get; set; }
        public string CusTomVal { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }

        public virtual UProduct Product { get; set; }
    }
}
