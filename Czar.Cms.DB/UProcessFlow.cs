using System;
using System.Collections.Generic;

namespace Czar.Cms.DB
{
    public partial class UProcessFlow
    {
        public UProcessFlow()
        {
            UProcessFlowList = new HashSet<UProcessFlowList>();
            UProcessFlowOperator = new HashSet<UProcessFlowOperator>();
        }

        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int BillState { get; set; }
        public DateTime? SendDate { get; set; }
        public int? CustomerId { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }
        public string FactCode { get; set; }
        public int? GoodsId { get; set; }
        public string GoodsCode { get; set; }
        public decimal? StockQuantity { get; set; }
        public decimal PlanQuantity { get; set; }
        public decimal Quantity { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreteId { get; set; }
        public int ShopId { get; set; }
        public bool? CkWf { get; set; }
        public int? VendorId { get; set; }
        public string ContractCode { get; set; }
        public string SpecifiCation { get; set; }
        public string MaterialName { get; set; }
        public string Memo { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public string MadeState { get; set; }
        public string CardCode { get; set; }
        public DateTime? CardOpenTime { get; set; }
        public DateTime? FinDate { get; set; }
        public decimal? Amount { get; set; }

        public virtual SysCompany Company { get; set; }
        public virtual UShop Shop { get; set; }
        public virtual ICollection<UProcessFlowList> UProcessFlowList { get; set; }
        public virtual ICollection<UProcessFlowOperator> UProcessFlowOperator { get; set; }
    }
}
