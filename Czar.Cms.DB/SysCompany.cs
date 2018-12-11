using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class SysCompany
    {
        public SysCompany()
        {
            UFactOrder = new HashSet<UFactOrder>();
            ULoginUser = new HashSet<ULoginUser>();
            UProcessFlow = new HashSet<UProcessFlow>();
            UPurchaseOrder = new HashSet<UPurchaseOrder>();
            USaleOrder = new HashSet<USaleOrder>();
        }

        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyFullName { get; set; }
        public string CompanyAddress { get; set; }
        public string Contacts { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? CheckDate { get; set; }
        public bool IsLok { get; set; }
        public bool Effective { get; set; }
        public int? SysUserId { get; set; }
        public int Type { get; set; }
        public string PhoneNumber { get; set; }

        public virtual SysRegist SysRegist { get; set; }
        public virtual ICollection<UFactOrder> UFactOrder { get; set; }
        public virtual ICollection<ULoginUser> ULoginUser { get; set; }
        public virtual ICollection<UProcessFlow> UProcessFlow { get; set; }
        public virtual ICollection<UPurchaseOrder> UPurchaseOrder { get; set; }
        public virtual ICollection<USaleOrder> USaleOrder { get; set; }
    }
}
