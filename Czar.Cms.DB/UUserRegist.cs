using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UUserRegist
    {
        public int Id { get; set; }
        public string ContactsName { get; set; }
        public string Tel { get; set; }
        public string CardId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public int ReistType { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int CompanyId { get; set; }
        public int CheckState { get; set; }
        public int OpenId { get; set; }
    }
}
