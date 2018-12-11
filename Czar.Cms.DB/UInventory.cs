using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UInventory
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ShopId { get; set; }
        public int ProductId { get; set; }
        public decimal BaseQuantity { get; set; }
        public decimal Quantity { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdatePersonId { get; set; }
        public decimal? DoStock { get; set; }

        public virtual UProduct Product { get; set; }
        public virtual UShop Shop { get; set; }
    }
}
