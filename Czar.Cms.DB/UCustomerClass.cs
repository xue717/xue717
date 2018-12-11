using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UCustomerClass
    {
        public UCustomerClass()
        {
            UCustomer = new HashSet<UCustomer>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }
        public string Memo { get; set; }
        public DateTime Createtime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }
        public bool Effective { get; set; }
        public int? ParentId { get; set; }
        public string AllPid { get; set; }

        public virtual ICollection<UCustomer> UCustomer { get; set; }
    }
}
