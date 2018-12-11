using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UWeixin
    {
        public string OpenId { get; set; }
        public string NickName { get; set; }
        public int? Sex { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string HeadimgUrl { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Tel { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
