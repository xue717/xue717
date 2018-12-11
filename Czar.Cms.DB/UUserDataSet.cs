using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UUserDataSet
    {
        public int Id { get; set; }
        public int? DataType { get; set; }
        public int? DataId { get; set; }
        public int? CompanyId { get; set; }
        public int? CreateId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UserId { get; set; }
    }
}
