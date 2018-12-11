using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProduct
    {
        public UProduct()
        {
            UInventory = new HashSet<UInventory>();
            UProductCustom = new HashSet<UProductCustom>();
            UProductImg = new HashSet<UProductImg>();
            UPurchaseOrderB = new HashSet<UPurchaseOrderB>();
            USaleOrderB = new HashSet<USaleOrderB>();
        }

        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductSpec { get; set; }
        public int ClassId { get; set; }
        public int UnitId { get; set; }
        public int? MatTypeId { get; set; }
        public string BarCode { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? StockQty { get; set; }
        public string Memo { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int CreateId { get; set; }
        public bool Effective { get; set; }
        public int CompanyId { get; set; }
        public bool IsMat { get; set; }
        public decimal? Quotiety { get; set; }
        public decimal? Diameter { get; set; }
        public decimal? InDiameter { get; set; }
        public decimal? Height { get; set; }
        public bool? IsSuite { get; set; }
        public decimal? MaxStock { get; set; }
        public decimal? MixStock { get; set; }
        public string Cnumber { get; set; }
        public bool? IsOutsource { get; set; }
        public bool? IsMould { get; set; }

        public virtual UProductClass Class { get; set; }
        public virtual UMatType MatType { get; set; }
        public virtual ICollection<UInventory> UInventory { get; set; }
        public virtual ICollection<UProductCustom> UProductCustom { get; set; }
        public virtual ICollection<UProductImg> UProductImg { get; set; }
        public virtual ICollection<UPurchaseOrderB> UPurchaseOrderB { get; set; }
        public virtual ICollection<USaleOrderB> USaleOrderB { get; set; }
    }
}
