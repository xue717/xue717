using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UMatreckonSub
    {
        public int Id { get; set; }
        public int MatId { get; set; }
        public int ProductId { get; set; }
        public decimal PurUsed { get; set; }
        public bool State { get; set; }
        public decimal? SafeStock { get; set; }
        public decimal? MakUsed { get; set; }
        public decimal? PlanPurUsed { get; set; }
        public int? VendorId { get; set; }
        public int? OperId { get; set; }
        public DateTime? OperTime { get; set; }
        public int? PurId { get; set; }
        public decimal? PlanMakUsed { get; set; }

        public virtual UMatreckon IdNavigation { get; set; }
    }
}
