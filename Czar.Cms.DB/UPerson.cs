using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UPerson
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string PersonCode { get; set; }
        public string Telephone { get; set; }
        public string Sex { get; set; }
        public bool IsSale { get; set; }
        public bool Effective { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }
        public int DeptId { get; set; }
        public string CardCode { get; set; }
        public int? LoginUserId { get; set; }
        public string EnglishName { get; set; }

        public virtual UDept Dept { get; set; }
    }
}
