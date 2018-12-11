using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class ULoginUser
    {
        public ULoginUser()
        {
            SysUserrole = new HashSet<SysUserrole>();
            UMessage = new HashSet<UMessage>();
        }

        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Tel { get; set; }
        public string PassWord { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int? ShopId { get; set; }
        public int CompanyId { get; set; }
        public bool IsAdmin { get; set; }
        public bool Effective { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string UserImg { get; set; }

        public virtual SysCompany Company { get; set; }
        public virtual UShop Shop { get; set; }
        public virtual ICollection<SysUserrole> SysUserrole { get; set; }
        public virtual ICollection<UMessage> UMessage { get; set; }
    }
}
