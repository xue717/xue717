using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysParam
    {
        public SysParam()
        {
            SysParamVal = new HashSet<SysParamVal>();
        }

        public int Id { get; set; }
        public int? MId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public int ParamType { get; set; }
        public string DeftVal { get; set; }

        public virtual ICollection<SysParamVal> SysParamVal { get; set; }
    }
}
