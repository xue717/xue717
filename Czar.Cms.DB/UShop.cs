using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UShop
    {
        public UShop()
        {
            UFactOrder = new HashSet<UFactOrder>();
            UInventory = new HashSet<UInventory>();
            ULoginUser = new HashSet<ULoginUser>();
            UProcessFlow = new HashSet<UProcessFlow>();
            UPurchaseOrder = new HashSet<UPurchaseOrder>();
            USaleOrder = new HashSet<USaleOrder>();
            UStockCheck = new HashSet<UStockCheck>();
            UStockOtherin = new HashSet<UStockOtherin>();
            UStockOtherout = new HashSet<UStockOtherout>();
            UStockin = new HashSet<UStockin>();
            UStockout = new HashSet<UStockout>();
            UTransfersInShop = new HashSet<UTransfers>();
            UTransfersOutShop = new HashSet<UTransfers>();
        }

        public int ShopId { get; set; }
        public int CompanyId { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string Tel { get; set; }
        public string Memo { get; set; }
        public int PersonId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public bool Effective { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? StockType { get; set; }

        public virtual ICollection<UFactOrder> UFactOrder { get; set; }
        public virtual ICollection<UInventory> UInventory { get; set; }
        public virtual ICollection<ULoginUser> ULoginUser { get; set; }
        public virtual ICollection<UProcessFlow> UProcessFlow { get; set; }
        public virtual ICollection<UPurchaseOrder> UPurchaseOrder { get; set; }
        public virtual ICollection<USaleOrder> USaleOrder { get; set; }
        public virtual ICollection<UStockCheck> UStockCheck { get; set; }
        public virtual ICollection<UStockOtherin> UStockOtherin { get; set; }
        public virtual ICollection<UStockOtherout> UStockOtherout { get; set; }
        public virtual ICollection<UStockin> UStockin { get; set; }
        public virtual ICollection<UStockout> UStockout { get; set; }
        public virtual ICollection<UTransfers> UTransfersInShop { get; set; }
        public virtual ICollection<UTransfers> UTransfersOutShop { get; set; }
    }
}
