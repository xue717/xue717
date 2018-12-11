using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Czar.Cms.DB
{
    public partial class cy_platform_rcContext : DbContext
    {
        public cy_platform_rcContext()
        {
        }

        public cy_platform_rcContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<SysAppUpdate> SysAppUpdate { get; set; }
        public virtual DbSet<SysCodeVal> SysCodeVal { get; set; }
        public virtual DbSet<SysCompany> SysCompany { get; set; }
        public virtual DbSet<SysKuaidi> SysKuaidi { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }
        public virtual DbSet<SysModels> SysModels { get; set; }
        public virtual DbSet<SysModelsRights> SysModelsRights { get; set; }
        public virtual DbSet<SysParam> SysParam { get; set; }
        public virtual DbSet<SysParamVal> SysParamVal { get; set; }
        public virtual DbSet<SysPower> SysPower { get; set; }
        public virtual DbSet<SysPowerTwo> SysPowerTwo { get; set; }
        public virtual DbSet<SysPowerTwoVal> SysPowerTwoVal { get; set; }
        public virtual DbSet<SysPowerVal> SysPowerVal { get; set; }
        public virtual DbSet<SysProblem> SysProblem { get; set; }
        public virtual DbSet<SysProblemB> SysProblemB { get; set; }
        public virtual DbSet<SysProblemUrl> SysProblemUrl { get; set; }
        public virtual DbSet<SysRegist> SysRegist { get; set; }
        public virtual DbSet<SysRegister> SysRegister { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<SysRoleRights> SysRoleRights { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<SysUserrole> SysUserrole { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<UAccount> UAccount { get; set; }
        public virtual DbSet<UCurrencyType> UCurrencyType { get; set; }
        public virtual DbSet<UCustomer> UCustomer { get; set; }
        public virtual DbSet<UCustomerClass> UCustomerClass { get; set; }
        public virtual DbSet<UDayplan> UDayplan { get; set; }
        public virtual DbSet<UDept> UDept { get; set; }
        public virtual DbSet<UExpense> UExpense { get; set; }
        public virtual DbSet<UExpensecost> UExpensecost { get; set; }
        public virtual DbSet<UExpensecostB> UExpensecostB { get; set; }
        public virtual DbSet<UFactOrder> UFactOrder { get; set; }
        public virtual DbSet<UFactOrderAttachments> UFactOrderAttachments { get; set; }
        public virtual DbSet<UFactOrderB> UFactOrderB { get; set; }
        public virtual DbSet<UFactOrderSub> UFactOrderSub { get; set; }
        public virtual DbSet<UIncome> UIncome { get; set; }
        public virtual DbSet<UIncomeB> UIncomeB { get; set; }
        public virtual DbSet<UIncometype> UIncometype { get; set; }
        public virtual DbSet<UInstall> UInstall { get; set; }
        public virtual DbSet<UInstallB> UInstallB { get; set; }
        public virtual DbSet<UInstallSub> UInstallSub { get; set; }
        public virtual DbSet<UInventory> UInventory { get; set; }
        public virtual DbSet<UInvoiceType> UInvoiceType { get; set; }
        public virtual DbSet<ULoginUser> ULoginUser { get; set; }
        public virtual DbSet<UMachine> UMachine { get; set; }
        public virtual DbSet<UMakeperson> UMakeperson { get; set; }
        public virtual DbSet<UMakereport> UMakereport { get; set; }
        public virtual DbSet<UMakereportB> UMakereportB { get; set; }
        public virtual DbSet<UMatType> UMatType { get; set; }
        public virtual DbSet<UMatreckon> UMatreckon { get; set; }
        public virtual DbSet<UMatreckonB> UMatreckonB { get; set; }
        public virtual DbSet<UMatreckonSub> UMatreckonSub { get; set; }
        public virtual DbSet<UMatterClass> UMatterClass { get; set; }
        public virtual DbSet<UMessage> UMessage { get; set; }
        public virtual DbSet<UNotice> UNotice { get; set; }
        public virtual DbSet<UOrderBom> UOrderBom { get; set; }
        public virtual DbSet<UOrderBomB> UOrderBomB { get; set; }
        public virtual DbSet<UOutsource> UOutsource { get; set; }
        public virtual DbSet<UOutsourceAttachments> UOutsourceAttachments { get; set; }
        public virtual DbSet<UOutsourceB> UOutsourceB { get; set; }
        public virtual DbSet<UPayment> UPayment { get; set; }
        public virtual DbSet<UPaymentB> UPaymentB { get; set; }
        public virtual DbSet<UPerson> UPerson { get; set; }
        public virtual DbSet<UPersonwages> UPersonwages { get; set; }
        public virtual DbSet<UPickmaterial> UPickmaterial { get; set; }
        public virtual DbSet<UPickmaterialB> UPickmaterialB { get; set; }
        public virtual DbSet<UPickmaterialC> UPickmaterialC { get; set; }
        public virtual DbSet<UPrint> UPrint { get; set; }
        public virtual DbSet<UProcess> UProcess { get; set; }
        public virtual DbSet<UProcessAction> UProcessAction { get; set; }
        public virtual DbSet<UProcessFlow> UProcessFlow { get; set; }
        public virtual DbSet<UProcessFlowB> UProcessFlowB { get; set; }
        public virtual DbSet<UProcessFlowList> UProcessFlowList { get; set; }
        public virtual DbSet<UProcessFlowOperator> UProcessFlowOperator { get; set; }
        public virtual DbSet<UProduct> UProduct { get; set; }
        public virtual DbSet<UProductBom> UProductBom { get; set; }
        public virtual DbSet<UProductBomB> UProductBomB { get; set; }
        public virtual DbSet<UProductClass> UProductClass { get; set; }
        public virtual DbSet<UProductCustom> UProductCustom { get; set; }
        public virtual DbSet<UProductImg> UProductImg { get; set; }
        public virtual DbSet<UPurchaseOrder> UPurchaseOrder { get; set; }
        public virtual DbSet<UPurchaseOrderB> UPurchaseOrderB { get; set; }
        public virtual DbSet<UQuote> UQuote { get; set; }
        public virtual DbSet<UQuoteB> UQuoteB { get; set; }
        public virtual DbSet<URemark> URemark { get; set; }
        public virtual DbSet<USaleDelivery> USaleDelivery { get; set; }
        public virtual DbSet<USaleDeliveryB> USaleDeliveryB { get; set; }
        public virtual DbSet<USaleOrder> USaleOrder { get; set; }
        public virtual DbSet<USaleOrderB> USaleOrderB { get; set; }
        public virtual DbSet<USettlement> USettlement { get; set; }
        public virtual DbSet<USettlementB> USettlementB { get; set; }
        public virtual DbSet<UShop> UShop { get; set; }
        public virtual DbSet<UStockCheck> UStockCheck { get; set; }
        public virtual DbSet<UStockCheckB> UStockCheckB { get; set; }
        public virtual DbSet<UStockOtherin> UStockOtherin { get; set; }
        public virtual DbSet<UStockOtherinB> UStockOtherinB { get; set; }
        public virtual DbSet<UStockOtherout> UStockOtherout { get; set; }
        public virtual DbSet<UStockOtheroutB> UStockOtheroutB { get; set; }
        public virtual DbSet<UStockin> UStockin { get; set; }
        public virtual DbSet<UStockinB> UStockinB { get; set; }
        public virtual DbSet<UStockout> UStockout { get; set; }
        public virtual DbSet<UStockoutB> UStockoutB { get; set; }
        public virtual DbSet<UTransfers> UTransfers { get; set; }
        public virtual DbSet<UTransfersB> UTransfersB { get; set; }
        public virtual DbSet<UUnit> UUnit { get; set; }
        public virtual DbSet<UUserDataSet> UUserDataSet { get; set; }
        public virtual DbSet<UUserRegist> UUserRegist { get; set; }
        public virtual DbSet<UVendor> UVendor { get; set; }
        public virtual DbSet<UVendorClass> UVendorClass { get; set; }
        public virtual DbSet<UWeixin> UWeixin { get; set; }
        public virtual DbSet<YhApiapp> YhApiapp { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<SysAppUpdate>(entity =>
            {
                entity.ToTable("sys_app_update");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppVersion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CraeteTime).HasColumnType("datetime");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysCodeVal>(entity =>
            {
                entity.ToTable("sys_code_val");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyId).HasColumnName("ModifyID");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("sys_company");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFullName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Contacts)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SysUserId).HasColumnName("SysUserID");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysKuaidi>(entity =>
            {
                entity.ToTable("sys_kuaidi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.ToTable("sys_log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HostAddress).HasMaxLength(50);

                entity.Property(e => e.LogContent)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysModels>(entity =>
            {
                entity.ToTable("sys_models");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysModelsRights>(entity =>
            {
                entity.ToTable("sys_models_rights");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysParam>(entity =>
            {
                entity.ToTable("sys_param");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeftVal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MId).HasColumnName("M_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysParamVal>(entity =>
            {
                entity.ToTable("sys_param_val");

                entity.HasIndex(e => e.PId)
                    .HasName("IX_FK_sys_param_val_sys_param");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ModfiyTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyId).HasColumnName("ModifyID");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.Val)
                    .IsRequired()
                    .HasColumnName("val")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.SysParamVal)
                    .HasForeignKey(d => d.PId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_param_val_sys_param");
            });

            modelBuilder.Entity<SysPower>(entity =>
            {
                entity.ToTable("sys_Power");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysPowerTwo>(entity =>
            {
                entity.ToTable("sys_PowerTwo");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysPowerTwoVal>(entity =>
            {
                entity.ToTable("sys_PowerTwo_val");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<SysPowerVal>(entity =>
            {
                entity.ToTable("sys_Power_val");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<SysProblem>(entity =>
            {
                entity.ToTable("sys_problem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysProblemB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("sys_problem_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_sys_problem_b_sys_problem");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RespContent)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.RespId).HasColumnName("RespID");

                entity.Property(e => e.RespTime).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SysProblemB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_sys_problem_b_sys_problem");
            });

            modelBuilder.Entity<SysProblemUrl>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("sys_problem_url");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_sys_sttachment_sys_problem");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CareteId).HasColumnName("CareteID");

                entity.Property(e => e.CreatTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SysProblemUrl)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_sys_sttachment_sys_problem");
            });

            modelBuilder.Entity<SysRegist>(entity =>
            {
                entity.ToTable("sys_regist");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.RegistTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SysUserId).HasColumnName("SysUserID");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.SysRegist)
                    .HasForeignKey<SysRegist>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_regist_sys_company");
            });

            modelBuilder.Entity<SysRegister>(entity =>
            {
                entity.ToTable("sys_register");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OpenId)
                    .IsRequired()
                    .HasColumnName("OpenID")
                    .HasMaxLength(50);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.ToTable("sys_role");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateId).HasColumnName("UpdateID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysRoleRights>(entity =>
            {
                entity.ToTable("sys_role_rights");

                entity.HasIndex(e => e.ModelId)
                    .HasName("IX_FK_sys_role_rights_sys_models");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_FK_sys_role_rights_sys_role");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdateId).HasColumnName("UpdateID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.SysRoleRights)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_role_rights_sys_models");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysRoleRights)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_sys_role_rights_sys_role");
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("sys_user");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsSystem).HasColumnName("isSystem");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserImg).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysUserrole>(entity =>
            {
                entity.ToTable("sys_userrole");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_FK_sys_userrole_sys_role");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_sys_userrole_sys_user");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.Createtime).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysUserrole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_userrole_sys_role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysUserrole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_userrole_sys_user");
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.DiagramId);

                entity.ToTable("sysdiagrams");

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<UAccount>(entity =>
            {
                entity.ToTable("u_account");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UCurrencyType>(entity =>
            {
                entity.ToTable("u_currency_type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Parities).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UCustomer>(entity =>
            {
                entity.ToTable("u_customer");

                entity.HasIndex(e => e.ClassId)
                    .HasName("IX_FK_u_customer_u_customerclass");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.AdvAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankNum).HasMaxLength(50);

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Contacts).HasMaxLength(50);

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxName).HasMaxLength(50);

                entity.Property(e => e.LastSingleTime).HasColumnType("datetime");

                entity.Property(e => e.Memo).HasMaxLength(300);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PostNum).HasMaxLength(50);

                entity.Property(e => e.ReceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.UCustomer)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_customer_u_customerclass");
            });

            modelBuilder.Entity<UCustomerClass>(entity =>
            {
                entity.ToTable("u_customer_class");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllPid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.Createtime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<UDayplan>(entity =>
            {
                entity.ToTable("u_dayplan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FactCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactId).HasColumnName("FactID");

                entity.Property(e => e.PlanDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<UDept>(entity =>
            {
                entity.ToTable("u_dept");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllPid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<UExpense>(entity =>
            {
                entity.ToTable("u_expense");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UExpensecost>(entity =>
            {
                entity.ToTable("u_expensecost");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<UExpensecostB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_expensecost_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_expensecost_b_u_expensecost");

                entity.Property(e => e.SeqId)
                    .HasColumnName("SeqID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UExpensecostB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_expensecost_b_u_expensecost");
            });

            modelBuilder.Entity<UFactOrder>(entity =>
            {
                entity.ToTable("u_fact_order");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_FK_u_fact_order_sys_company");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_fact_order_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DepositAmountOff).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Discount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExpectDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalId)
                    .HasColumnName("ExternalID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Tel)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UFactOrder)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_fact_order_sys_company");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UFactOrder)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_fact_order_u_shop");
            });

            modelBuilder.Entity<UFactOrderAttachments>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_fact_order_attachments");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_fact_order_attachments_u_fact_order");

                entity.Property(e => e.SeqId)
                    .HasColumnName("SeqID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DownUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UFactOrderAttachments)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_fact_order_attachments_u_fact_order");
            });

            modelBuilder.Entity<UFactOrderB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_fact_order_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_fact_order_b_u_fact_order");

                entity.Property(e => e.SeqId)
                    .HasColumnName("SeqID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExpectDate).HasColumnType("datetime");

                entity.Property(e => e.FactCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.SeparateNum)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SpecifiCation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Unitprice).HasColumnType("decimal(14, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UFactOrderB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_fact_order_b_u_fact_order");
            });

            modelBuilder.Entity<UFactOrderSub>(entity =>
            {
                entity.HasKey(e => e.SubId);

                entity.ToTable("u_fact_order_sub");

                entity.HasIndex(e => e.SeqId)
                    .HasName("IX_FK_u_fact_order_sub_u_fact_order_b");

                entity.Property(e => e.SubId)
                    .HasColumnName("SubID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FactCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId).HasColumnName("GoodsID");

                entity.Property(e => e.GoodsName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Qauntity).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.SeqId)
                    .HasColumnName("SeqID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToothName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToothNumb).HasColumnType("decimal(14, 4)");

                entity.HasOne(d => d.Seq)
                    .WithMany(p => p.UFactOrderSub)
                    .HasForeignKey(d => d.SeqId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_u_fact_order_sub_u_fact_order_b");
            });

            modelBuilder.Entity<UIncome>(entity =>
            {
                entity.ToTable("u_income");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<UIncomeB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_income_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_income_b_u_income");

                entity.HasIndex(e => e.IncomeTypeId)
                    .HasName("IX_FK_u_income_b_u_incometype");

                entity.Property(e => e.SeqId)
                    .HasColumnName("SeqID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IncomeTypeId).HasColumnName("IncomeTypeID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UIncomeB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_income_b_u_income");

                entity.HasOne(d => d.IncomeType)
                    .WithMany(p => p.UIncomeB)
                    .HasForeignKey(d => d.IncomeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_income_b_u_incometype");
            });

            modelBuilder.Entity<UIncometype>(entity =>
            {
                entity.ToTable("u_incometype");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UInstall>(entity =>
            {
                entity.ToTable("u_install");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");
            });

            modelBuilder.Entity<UInstallB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_install_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_install_b_u_install");

                entity.Property(e => e.SeqId).HasColumnName("SeqID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UInstallB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_install_b_u_install");
            });

            modelBuilder.Entity<UInstallSub>(entity =>
            {
                entity.HasKey(e => e.SubId);

                entity.ToTable("u_install_sub");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_install_sub_u_install");

                entity.HasIndex(e => e.SeqId)
                    .HasName("IX_FK_u_install_sub_u_install_b");

                entity.Property(e => e.SubId).HasColumnName("SubID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SeqId).HasColumnName("SeqID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UInstallSub)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_install_sub_u_install");

                entity.HasOne(d => d.Seq)
                    .WithMany(p => p.UInstallSub)
                    .HasForeignKey(d => d.SeqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_install_sub_u_install_b");
            });

            modelBuilder.Entity<UInventory>(entity =>
            {
                entity.ToTable("u_inventory");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_FK_u_inventory_u_product");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_inventory_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseQuantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DoStock).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.UpdatePersonId).HasColumnName("UpdatePersonID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UInventory)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_u_inventory_u_product");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UInventory)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_inventory_u_shop");
            });

            modelBuilder.Entity<UInvoiceType>(entity =>
            {
                entity.ToTable("u_invoice_type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ULoginUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("u_login_user");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_FK_u_login_user_sys_company");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_login_user_u_shop");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserImg).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ULoginUser)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_login_user_sys_company");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ULoginUser)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_u_login_user_u_shop");
            });

            modelBuilder.Entity<UMachine>(entity =>
            {
                entity.ToTable("u_machine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UMakeperson>(entity =>
            {
                entity.ToTable("u_makeperson");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");
            });

            modelBuilder.Entity<UMakereport>(entity =>
            {
                entity.ToTable("u_makereport");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UMakereportB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_makereport_b");

                entity.Property(e => e.SeqId).HasColumnName("SeqID");

                entity.Property(e => e.FactId).HasColumnName("FactID");

                entity.Property(e => e.FinQuantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FlowId).HasColumnName("FlowID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UMakereportB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_makereport_b_u_makereport");
            });

            modelBuilder.Entity<UMatType>(entity =>
            {
                entity.ToTable("u_mat_type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UMatreckon>(entity =>
            {
                entity.ToTable("u_matreckon");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyId).HasColumnName("ModifyID");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<UMatreckonB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_matreckon_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_matreckon_b_u_matreckon");

                entity.Property(e => e.SeqId).HasColumnName("SeqID");

                entity.Property(e => e.BomId).HasColumnName("BomID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UMatreckonB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_matreckon_b_u_matreckon");
            });

            modelBuilder.Entity<UMatreckonSub>(entity =>
            {
                entity.HasKey(e => e.MatId);

                entity.ToTable("u_matreckon_sub");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_matreckon_sub_u_matreckon");

                entity.Property(e => e.MatId).HasColumnName("MatID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MakUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.OperId).HasColumnName("OperID");

                entity.Property(e => e.OperTime).HasColumnType("datetime");

                entity.Property(e => e.PlanMakUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.PlanPurUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PurId).HasColumnName("PurID");

                entity.Property(e => e.PurUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.SafeStock).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UMatreckonSub)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_matreckon_sub_u_matreckon");
            });

            modelBuilder.Entity<UMatterClass>(entity =>
            {
                entity.ToTable("u_matter_class");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UMessage>(entity =>
            {
                entity.ToTable("u_message");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_FK_u_message_u_login_user");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Contnet)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.UMessage)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_message_u_login_user");
            });

            modelBuilder.Entity<UNotice>(entity =>
            {
                entity.ToTable("u_notice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UOrderBom>(entity =>
            {
                entity.ToTable("u_order_bom");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");
            });

            modelBuilder.Entity<UOrderBomB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_order_bom_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_order_bom_b_u_order_bom");

                entity.Property(e => e.SeqId).HasColumnName("SeqID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MakRate).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.MakUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.OwerId)
                    .IsRequired()
                    .HasColumnName("OwerID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PurRate).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.PurUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.QuotPrice).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.StandUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(14, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UOrderBomB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_order_bom_b_u_order_bom");
            });

            modelBuilder.Entity<UOutsource>(entity =>
            {
                entity.ToTable("u_outsource");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.ChecTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<UOutsourceAttachments>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_outsource_attachments");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_outsource_attachments_u_outsource");

                entity.Property(e => e.SeqId)
                    .HasColumnName("SeqID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DownUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UOutsourceAttachments)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_outsource_attachments_u_outsource");
            });

            modelBuilder.Entity<UOutsourceB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_outsource_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_outsource_b_u_outsource");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FinQuantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UOutsourceB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_outsource_b_u_outsource");
            });

            modelBuilder.Entity<UPayment>(entity =>
            {
                entity.ToTable("u_payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<UPaymentB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_payment_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_payment_b_u_payment");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UPaymentB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_payment_b_u_payment");
            });

            modelBuilder.Entity<UPerson>(entity =>
            {
                entity.ToTable("u_person");

                entity.HasIndex(e => e.DeptId)
                    .HasName("IX_FK_u_person_u_dept");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.EnglishName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginUserId).HasColumnName("LoginUserID");

                entity.Property(e => e.PersonCode)
                    .IsRequired()
                    .HasColumnName("personCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.UPerson)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_person_u_dept");
            });

            modelBuilder.Entity<UPersonwages>(entity =>
            {
                entity.ToTable("u_personwages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.FinQuantity).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FlowId).HasColumnName("FlowID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ReportTime).HasColumnType("datetime");

                entity.Property(e => e.SourceSeqId).HasColumnName("SourceSeqID");
            });

            modelBuilder.Entity<UPickmaterial>(entity =>
            {
                entity.ToTable("u_pickmaterial");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");
            });

            modelBuilder.Entity<UPickmaterialB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_pickmaterial_b");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProFlowCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProFlowId)
                    .IsRequired()
                    .HasColumnName("ProFlowID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<UPickmaterialC>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_pickmaterial_c");

                entity.Property(e => e.SeqId).HasColumnName("SeqID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveryQty).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.DiffQuantity).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.NeedQuantity).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OwnerID")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProFlowId)
                    .HasColumnName("ProFlowID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RealQuantity).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<UPrint>(entity =>
            {
                entity.ToTable("u_print");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PrintCode).HasMaxLength(50);

                entity.Property(e => e.PrintName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UProcess>(entity =>
            {
                entity.ToTable("u_process");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateId).HasColumnName("UpdateID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UProcessAction>(entity =>
            {
                entity.ToTable("u_process_action");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateId).HasColumnName("UpdateID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UProcessFlow>(entity =>
            {
                entity.ToTable("u_process_flow");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_FK_u_process_flow_sys_company");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_process_flow_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CardCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardOpenTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.CkWf).HasColumnName("CkWF");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.FactCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinDate).HasColumnType("datetime");

                entity.Property(e => e.GoodsCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId).HasColumnName("GoodsID");

                entity.Property(e => e.MadeState)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PlanQuantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SpecifiCation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockQuantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UProcessFlow)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_process_flow_sys_company");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UProcessFlow)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_process_flow_u_shop");
            });

            modelBuilder.Entity<UProcessFlowB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_process_flow_b");

                entity.Property(e => e.SeqId)
                    .HasColumnName("SeqID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualTime).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CkWf).HasColumnName("CkWF");

                entity.Property(e => e.FinQuantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId)
                    .HasColumnName("OperatorID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwderId)
                    .HasColumnName("OwderID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.QuotationTime).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Wfqty)
                    .HasColumnName("WFQty")
                    .HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<UProcessFlowList>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("u_process_flow_list");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_process_flow_list_u_process_flow");

                entity.Property(e => e.ListId)
                    .HasColumnName("ListID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BadQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinQuantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.GoodsId).HasColumnName("GoodsID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperationEnd).HasColumnType("datetime");

                entity.Property(e => e.OperationStart).HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UProcessFlowList)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_process_flow_list_u_process_flow");
            });

            modelBuilder.Entity<UProcessFlowOperator>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("u_process_flow_operator");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_process_flow_operator_u_process_flow");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.BadQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UProcessFlowOperator)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_u_process_flow_operator_u_process_flow");
            });

            modelBuilder.Entity<UProduct>(entity =>
            {
                entity.ToTable("u_product");

                entity.HasIndex(e => e.ClassId)
                    .HasName("IX_FK_u_product_u_product_class");

                entity.HasIndex(e => e.MatTypeId)
                    .HasName("IX_FK_u_product_u_mat_type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Cnumber)
                    .HasColumnName("CNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostPrice).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Diameter).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Height).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.InDiameter).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.MatTypeId).HasColumnName("MatTypeID");

                entity.Property(e => e.MaxStock).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MixStock).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSpec)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quotiety).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.StockQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.UProduct)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_product_u_product_class");

                entity.HasOne(d => d.MatType)
                    .WithMany(p => p.UProduct)
                    .HasForeignKey(d => d.MatTypeId)
                    .HasConstraintName("FK_u_product_u_mat_type1");
            });

            modelBuilder.Entity<UProductBom>(entity =>
            {
                entity.ToTable("u_product_bom");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.Ver).HasColumnName("ver");
            });

            modelBuilder.Entity<UProductBomB>(entity =>
            {
                entity.HasKey(e => e.SeqId);

                entity.ToTable("u_product_bom_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_product_bom_b_u_product_bom");

                entity.Property(e => e.SeqId).HasColumnName("SeqID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MakRate).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.MakUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.OwerId)
                    .IsRequired()
                    .HasColumnName("OwerID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PurRate).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.PurUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.QuotPrice).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.StandUsed).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(14, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UProductBomB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_product_bom_b_u_product_bom");
            });

            modelBuilder.Entity<UProductClass>(entity =>
            {
                entity.ToTable("u_product_class");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllPid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatTime).HasColumnType("datetime");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UProductCustom>(entity =>
            {
                entity.ToTable("u_product_custom");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_FK_u_product_custom_u_product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CusTomName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CusTomVal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UProductCustom)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_u_product_custom_u_product");
            });

            modelBuilder.Entity<UProductImg>(entity =>
            {
                entity.ToTable("u_product_img");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_FK_u_product_img_u_product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CareteTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.ImgUrl)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UProductImg)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_u_product_img_u_product");
            });

            modelBuilder.Entity<UPurchaseOrder>(entity =>
            {
                entity.ToTable("u_purchase_order");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_FK_u_purchase_order_sys_company");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_purchase_order_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DepositAmountOff).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Discount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExpectDate).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StockInQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UPurchaseOrder)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_purchase_order_sys_company");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UPurchaseOrder)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_purchase_order_u_shop");
            });

            modelBuilder.Entity<UPurchaseOrderB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_purchase_order_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_purchase_order_b_u_purchase_order");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_FK_u_purchase_order_b_u_product");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.StockInQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UPurchaseOrderB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_purchase_order_b_u_purchase_order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UPurchaseOrderB)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_purchase_order_b_u_product");
            });

            modelBuilder.Entity<UQuote>(entity =>
            {
                entity.ToTable("u_quote");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Contacts).HasMaxLength(50);

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PostName).HasMaxLength(50);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ToFaxNum).HasMaxLength(50);
            });

            modelBuilder.Entity<UQuoteB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_quote_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_quote_b_u_quote");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Spec).HasMaxLength(50);

                entity.Property(e => e.TaxUnitPrice).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UQuoteB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_quote_b_u_quote");
            });

            modelBuilder.Entity<URemark>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Remark, e.CreatTime, e.CreateId, e.CompanyId });

                entity.ToTable("u_remark");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Remark)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatTime).HasColumnType("datetime");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            });

            modelBuilder.Entity<USaleDelivery>(entity =>
            {
                entity.ToTable("u_sale_delivery");

                entity.HasIndex(e => e.SourceId)
                    .HasName("IX_FK_u_sale_delivery_u_sale_order");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyName).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliverCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Discount).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceName).HasMaxLength(50);

                entity.Property(e => e.KdCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KdId).HasColumnName("KdID");

                entity.Property(e => e.LogisticsAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Parities).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReturnSourceId).HasColumnName("ReturnSourceID");

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<USaleDeliveryB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_sale_delivery_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_sale_delivery_b_u_sale_delivery");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CostPrice).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ExpectDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProducctId).HasColumnName("ProducctID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SettlementQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxUnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.USaleDeliveryB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_sale_delivery_b_u_sale_delivery");
            });

            modelBuilder.Entity<USaleOrder>(entity =>
            {
                entity.ToTable("u_sale_order");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_FK_u_sale_order_sys_company");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_sale_order_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyName).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DepositAmountOff).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Discount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExpectDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalId)
                    .HasColumnName("externalID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceName).HasMaxLength(50);

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Parities).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PostTime).HasMaxLength(50);

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SettlementWay).HasMaxLength(50);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.USaleOrder)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_sale_order_sys_company");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.USaleOrder)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_sale_order_u_shop");
            });

            modelBuilder.Entity<USaleOrderB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_sale_order_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_sale_order_b_u_sale_order");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_FK_u_sale_order_b_u_product");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeliveryQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ExpectDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxUnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.USaleOrderB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_sale_order_b_u_sale_order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.USaleOrderB)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_sale_order_b_u_product");
            });

            modelBuilder.Entity<USettlement>(entity =>
            {
                entity.ToTable("u_settlement");

                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_FK_u_settlement_u_account");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("billDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.ChecTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.USettlement)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_settlement_u_account");
            });

            modelBuilder.Entity<USettlementB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_settlement_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_settlement_b_u_settlement");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.USettlementB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_settlement_b_u_settlement");
            });

            modelBuilder.Entity<UShop>(entity =>
            {
                entity.HasKey(e => e.ShopId);

                entity.ToTable("u_shop");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ShopAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel).HasMaxLength(11);
            });

            modelBuilder.Entity<UStockCheck>(entity =>
            {
                entity.ToTable("u_stock_check");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_stock_check_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CheckBeginDate).HasColumnType("datetime");

                entity.Property(e => e.CheckEndDate).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UStockCheck)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_stock_check_u_shop");
            });

            modelBuilder.Entity<UStockCheckB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_stock_check_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_stock_check_b_u_stock_check");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BookAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BookQuantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CostPrice).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DiffAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiffQuantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DuringAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DuringQauntity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SeqCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UStockCheckB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_stock_check_b_u_stock_check");
            });

            modelBuilder.Entity<UStockOtherin>(entity =>
            {
                entity.ToTable("u_stock_otherin");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_stock_otherin_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UStockOtherin)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_stock_otherin_u_shop");
            });

            modelBuilder.Entity<UStockOtherinB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_stock_otherin_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_stock_otherin_b_u_stock_otherin");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UStockOtherinB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_stock_otherin_b_u_stock_otherin");
            });

            modelBuilder.Entity<UStockOtherout>(entity =>
            {
                entity.ToTable("u_stock_otherout");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_stock_otherout_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UStockOtherout)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_stock_otherout_u_shop");
            });

            modelBuilder.Entity<UStockOtheroutB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_stock_otherout_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_stock_otherout_b_u_stock_otherout");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UStockOtheroutB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_stock_otherout_b_u_stock_otherout");
            });

            modelBuilder.Entity<UStockin>(entity =>
            {
                entity.ToTable("u_stockin");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_stockin_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReturnSourceId).HasColumnName("ReturnSourceID");

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UStockin)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_stockin_u_shop");
            });

            modelBuilder.Entity<UStockinB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_stockin_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_stockin_b_u_stockin");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProducctId).HasColumnName("ProducctID");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UStockinB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_stockin_b_u_stockin");
            });

            modelBuilder.Entity<UStockout>(entity =>
            {
                entity.ToTable("u_stockout");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_FK_u_stockout_u_shop");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ReturnSourceId).HasColumnName("ReturnSourceID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UStockout)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_stockout_u_shop");
            });

            modelBuilder.Entity<UStockoutB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_stockout_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_stockout_b_u_stockout");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UStockoutB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_stockout_b_u_stockout");
            });

            modelBuilder.Entity<UTransfers>(entity =>
            {
                entity.ToTable("u_transfers");

                entity.HasIndex(e => e.InShopId)
                    .HasName("IX_FK_u_transfers_u_shop");

                entity.HasIndex(e => e.OutShopId)
                    .HasName("IX_FK_u_transfers_u_shop1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreteId).HasColumnName("CreteID");

                entity.Property(e => e.InShopId).HasColumnName("InShopID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OutShopId).HasColumnName("OutShopID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.InShop)
                    .WithMany(p => p.UTransfersInShop)
                    .HasForeignKey(d => d.InShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_transfers_u_shop");

                entity.HasOne(d => d.OutShop)
                    .WithMany(p => p.UTransfersOutShop)
                    .HasForeignKey(d => d.OutShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_transfers_u_shop1");
            });

            modelBuilder.Entity<UTransfersB>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("u_transfers_b");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_FK_u_transfers_b_u_transfers");

                entity.Property(e => e.Seq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UTransfersB)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_u_transfers_b_u_transfers");
            });

            modelBuilder.Entity<UUnit>(entity =>
            {
                entity.ToTable("u_unit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UUserDataSet>(entity =>
            {
                entity.ToTable("u_user_data_set");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataId).HasColumnName("DataID");
            });

            modelBuilder.Entity<UUserRegist>(entity =>
            {
                entity.ToTable("u_user_regist");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId)
                    .HasColumnName("CardID")
                    .HasMaxLength(30);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.ContactsName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OpenId).HasColumnName("OpenID");

                entity.Property(e => e.TaxNumber).HasMaxLength(20);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<UVendor>(entity =>
            {
                entity.ToTable("u_vendor");

                entity.HasIndex(e => e.ClassId)
                    .HasName("IX_FK_u_vendor_u_vendorclass");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdvAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FaxName).HasMaxLength(50);

                entity.Property(e => e.LastSingleTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.ReceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .IsRequired()
                    .HasColumnName("vendorCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasColumnName("vendorName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.UVendor)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_u_vendor_u_vendorclass");
            });

            modelBuilder.Entity<UVendorClass>(entity =>
            {
                entity.ToTable("u_vendor_class");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllPid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.Createtime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<UWeixin>(entity =>
            {
                entity.HasKey(e => e.OpenId);

                entity.ToTable("u_weixin");

                entity.Property(e => e.OpenId)
                    .HasColumnName("OpenID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HeadimgUrl).IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<YhApiapp>(entity =>
            {
                entity.ToTable("yhAPIApp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppSecret)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
