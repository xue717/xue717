using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProductImg
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string ImgUrl { get; set; }
        public DateTime CareteTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }

        public virtual UProduct Product { get; set; }
    }
}
