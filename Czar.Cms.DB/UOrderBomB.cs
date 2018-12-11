using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UOrderBomB
    {
        public int Id { get; set; }
        public int SeqId { get; set; }
        public int SeqIndex { get; set; }
        public int DeptId { get; set; }
        public int ProductId { get; set; }
        public string ParentId { get; set; }
        public int UnitId { get; set; }
        public decimal? QuotPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal StandUsed { get; set; }
        public decimal PurRate { get; set; }
        public decimal PurUsed { get; set; }
        public decimal? MakRate { get; set; }
        public decimal? MakUsed { get; set; }
        public string Memo { get; set; }
        public bool PutOut { get; set; }
        public bool Combin { get; set; }
        public bool Purchase { get; set; }
        public string OwerId { get; set; }
        public bool? Haveson { get; set; }

        public virtual UOrderBom IdNavigation { get; set; }
    }
}
