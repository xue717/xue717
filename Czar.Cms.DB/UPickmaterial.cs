using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UPickmaterial
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public int BillState { get; set; }
        public int BillType { get; set; }
        public int PersonId { get; set; }
        public int DeptId { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public int ShopId { get; set; }
        public int CompanyId { get; set; }
        public string Memo { get; set; }
    }
}
