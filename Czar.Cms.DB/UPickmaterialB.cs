using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UPickmaterialB
    {
        public int Id { get; set; }
        public int Seq { get; set; }
        public string Code { get; set; }
        public string ProFlowId { get; set; }
        public string ProFlowCode { get; set; }
        public int CustomerId { get; set; }
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public int Ver { get; set; }
        public int UnitId { get; set; }
        public int Quantity { get; set; }
    }
}
