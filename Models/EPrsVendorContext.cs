using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ePRS_VendorAPI.Models;

public partial class EPrsVendorContext : DbContext
{
    public EPrsVendorContext()
    {
    }

    public EPrsVendorContext(DbContextOptions<EPrsVendorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAdditionalItem> TblAdditionalItems { get; set; }

    public virtual DbSet<TblCurrency> TblCurrencies { get; set; }

    public virtual DbSet<TblEprrecord> TblEprrecords { get; set; }

    public virtual DbSet<TblErrorLog> TblErrorLogs { get; set; }

    public virtual DbSet<TblFile> TblFiles { get; set; }

    public virtual DbSet<TblHotaAn> TblHotaAns { get; set; }

    public virtual DbSet<TblHotaQn> TblHotaQns { get; set; }

    public virtual DbSet<TblItem> TblItems { get; set; }

    public virtual DbSet<TblLogAction> TblLogActions { get; set; }

    public virtual DbSet<TblLogEmail> TblLogEmails { get; set; }

    public virtual DbSet<TblLogLogin> TblLogLogins { get; set; }

    public virtual DbSet<TblLogin> TblLogins { get; set; }

    public virtual DbSet<TblLoginAdmin> TblLoginAdmins { get; set; }

    public virtual DbSet<TblLogonSession> TblLogonSessions { get; set; }

    public virtual DbSet<TblRequestorDetail> TblRequestorDetails { get; set; }

    public virtual DbSet<TblRiDetail> TblRiDetails { get; set; }

    public virtual DbSet<TblRiDetails2021bk> TblRiDetails2021bks { get; set; }

    public virtual DbSet<TblSysNotice> TblSysNotices { get; set; }

    public virtual DbSet<TblUom> TblUoms { get; set; }

    public virtual DbSet<TblVehicleLocation> TblVehicleLocations { get; set; }

    public virtual DbSet<TblVendorOtherDetail> TblVendorOtherDetails { get; set; }

    public virtual DbSet<TblVendorPrice> TblVendorPrices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAdditionalItem>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK_tblAdditionalItem");

            entity.ToTable("tblAdditionalItems");

            entity.Property(e => e.Sno).HasColumnName("SNo");
            entity.Property(e => e.AddItemDesc)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EPrno)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ePRNo");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Price).HasMaxLength(50);
            entity.Property(e => e.Qty)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Remarks).HasMaxLength(1500);
            entity.Property(e => e.Sgdprice)
                .HasMaxLength(50)
                .HasColumnName("SGDPrice");
            entity.Property(e => e.TotalPrice)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Uom)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UOM");
            entity.Property(e => e.VendorId)
                .HasMaxLength(255)
                .HasColumnName("VendorID");
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblCurrency>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__tblCurre__CA1EE04C0F575573");

            entity.ToTable("tblCurrency");

            entity.Property(e => e.Sno).HasColumnName("SNo");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SDescription)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("sDescription");
        });

        modelBuilder.Entity<TblEprrecord>(entity =>
        {
            entity.HasKey(e => e.EPrno).HasName("PK__tblEPRRe__DA2D3DA01BFD2C07");

            entity.ToTable("tblEPRRecords");

            entity.Property(e => e.EPrno)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ePRNo");
            entity.Property(e => e.Apoapprover)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("APOApprover");
            entity.Property(e => e.ApoconfigSno).HasColumnName("APOConfigSNo");
            entity.Property(e => e.ApolastActionBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APOLastActionBy");
            entity.Property(e => e.ApoqueryDate)
                .HasColumnType("datetime")
                .HasColumnName("APOQueryDate");
            entity.Property(e => e.ApoqueryFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("APOQueryFlag");
            entity.Property(e => e.ApoqueryRepliedDate)
                .HasColumnType("datetime")
                .HasColumnName("APOQueryRepliedDate");
            entity.Property(e => e.ChoiceReasonForLqw)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ChoiceReasonForLQW");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreationDate)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CreatorID");
            entity.Property(e => e.CreatorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeclareInterest)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeclareLabSpace)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EPrcreatedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("ePRCreatedDateTime");
            entity.Property(e => e.EPrtitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ePRTitle");
            entity.Property(e => e.EPrtype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ePRType");
            entity.Property(e => e.Ecapprover)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ECApprover");
            entity.Property(e => e.ImrelabCoord)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IMRELabCoord");
            entity.Property(e => e.ImrelabLoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IMRELabLoc");
            entity.Property(e => e.ImrelabNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IMRELabNo");
            entity.Property(e => e.Lqwapprover)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LQWApprover");
            entity.Property(e => e.ProjectCodesSno).HasColumnName("ProjectCodesSNo");
            entity.Property(e => e.PurchasingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rcapprover)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RCApprover");
            entity.Property(e => e.ReasonOfPurchase)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ReasonOfWaiver)
                .HasMaxLength(2500)
                .IsUnicode(false);
            entity.Property(e => e.RequestType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RequestorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RequestorID");
            entity.Property(e => e.RequestorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RI");
            entity.Property(e => e.Sappono)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAPPONo");
            entity.Property(e => e.Sapprno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAPPRNo");
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNo");
            entity.Property(e => e.SpecialInstructions)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SummaryItemTotal)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TotalLineItems)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblErrorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblErrorLog");

            entity.Property(e => e.EPrno)
                .HasMaxLength(50)
                .HasColumnName("ePRNo");
            entity.Property(e => e.ErrMessage).HasMaxLength(4000);
            entity.Property(e => e.LoginName).HasMaxLength(200);
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNo");
            entity.Property(e => e.TimeOfError).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblFiles");

            entity.Property(e => e.DeletedBy).HasMaxLength(255);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DocType).HasMaxLength(50);
            entity.Property(e => e.EPrno)
                .HasMaxLength(255)
                .HasColumnName("ePRNo");
            entity.Property(e => e.OriginalFileName).HasMaxLength(50);
            entity.Property(e => e.RenamedFileName).HasMaxLength(50);
            entity.Property(e => e.SDelete)
                .HasMaxLength(10)
                .HasColumnName("sDelete");
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNo");
            entity.Property(e => e.UploadedBy).HasMaxLength(255);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblHotaAn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblHOTA_Ans");

            entity.Property(e => e.Ans)
                .HasMaxLength(10)
                .HasColumnName("ans");
            entity.Property(e => e.AnsDetails).HasColumnName("ans_details");
            entity.Property(e => e.EPrno)
                .HasMaxLength(20)
                .HasColumnName("ePRNo");
            entity.Property(e => e.QnsId).HasColumnName("QnsID");
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
            entity.Property(e => e.VendorId)
                .HasMaxLength(255)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<TblHotaQn>(entity =>
        {
            entity.HasKey(e => e.Sno);

            entity.ToTable("tblHOTA_Qns");

            entity.Property(e => e.AddedBy).HasMaxLength(300);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(300);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasMaxLength(10);
        });

        modelBuilder.Entity<TblItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblItems");

            entity.Property(e => e.AddItemDesc)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EPrno)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ePRNo");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Price).HasMaxLength(50);
            entity.Property(e => e.Qty)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Sgdprice)
                .HasMaxLength(50)
                .HasColumnName("SGDPrice");
            entity.Property(e => e.TotalPrice)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Uom)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UOM");
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblLogAction>(entity =>
        {
            entity.HasKey(e => e.Sno)
                .HasName("PK__tblLog_A__CA1EE04D9F7E6BC5")
                .IsClustered(false);

            entity.ToTable("tblLog_Action");

            entity.Property(e => e.Sno).HasColumnName("SNo");
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.ActionDesc).HasMaxLength(255);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LoginId).HasMaxLength(255);
        });

        modelBuilder.Entity<TblLogEmail>(entity =>
        {
            entity.HasKey(e => e.Sno)
                .HasName("PK__tblLog_E__CA1EE04D451F3F6F")
                .IsClustered(false);

            entity.ToTable("tblLog_Email");

            entity.Property(e => e.Sno).HasColumnName("SNo");
            entity.Property(e => e.Addressee).HasMaxLength(255);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(255);
        });

        modelBuilder.Entity<TblLogLogin>(entity =>
        {
            entity.HasKey(e => e.Sno)
                .HasName("PK__tblLog_L__CA1EE04DC499DDCA")
                .IsClustered(false);

            entity.ToTable("tblLog_Login");

            entity.Property(e => e.Sno).HasColumnName("SNo");
            entity.Property(e => e.BrowserType).HasMaxLength(50);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LoginDate).HasColumnType("datetime");
            entity.Property(e => e.LoginId).HasMaxLength(255);
        });

        modelBuilder.Entity<TblLogin>(entity =>
        {
            entity.HasKey(e => e.Sno);

            entity.ToTable("tblLogin");

            entity.HasIndex(e => e.LoginId, "idx_LoginId");

            entity.HasIndex(e => e.Ri, "idx_RI");

            entity.HasIndex(e => e.VendorCode, "idx_VendorCode");

            entity.HasIndex(e => e.VendorName, "idx_VendorName");

            entity.HasIndex(e => e.EPrno, "idx_ePRNo");

            entity.Property(e => e.Sno).HasColumnName("SNo");
            entity.Property(e => e.CreatedBy).HasMaxLength(300);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EPrno)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ePRNo");
            entity.Property(e => e.Expired).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasMaxLength(10);
            entity.Property(e => e.LoginId).HasMaxLength(255);
            entity.Property(e => e.LoginPassword).HasMaxLength(255);
            entity.Property(e => e.Ri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RI");
            entity.Property(e => e.VendorCode).HasMaxLength(16);
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblLoginAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblLogin_Admin");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.LoginId)
                .HasMaxLength(255)
                .HasColumnName("LoginID");
            entity.Property(e => e.LoginPassword).HasMaxLength(255);
            entity.Property(e => e.Role).HasMaxLength(255);
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblLogonSession>(entity =>
        {
            entity.HasKey(e => e.Sno);

            entity.ToTable("tblLogonSessions");

            entity.Property(e => e.EPrno)
                .HasMaxLength(10)
                .HasColumnName("ePRNo");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LoginDate).HasColumnType("datetime");
            entity.Property(e => e.LoginId)
                .HasMaxLength(255)
                .HasColumnName("loginID");
            entity.Property(e => e.LogoutDate).HasColumnType("datetime");
            entity.Property(e => e.SessionId).HasColumnName("SessionID");
        });

        modelBuilder.Entity<TblRequestorDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRequestorDetails");

            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EPrno)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ePRNo");
            entity.Property(e => e.RequestorEmail)
                .HasMaxLength(320)
                .IsUnicode(false);
            entity.Property(e => e.Ri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RI");
            entity.Property(e => e.SNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("sNo");
        });

        modelBuilder.Entity<TblRiDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRI_Details");

            entity.Property(e => e.BillingRi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Billing_RI");
            entity.Property(e => e.Company).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(10);
            entity.Property(e => e.ExternalEntity).HasMaxLength(10);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.RiAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RI_Address");
            entity.Property(e => e.RiBuildingName)
                .HasMaxLength(100)
                .HasColumnName("RI_BuildingName");
            entity.Property(e => e.RiCoRegNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RI_CoRegNum");
            entity.Property(e => e.RiFullName)
                .HasMaxLength(100)
                .HasColumnName("RI_FullName");
            entity.Property(e => e.RiId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RI_Id");
            entity.Property(e => e.RiPostalCode)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("RI_PostalCode");
            entity.Property(e => e.RiPuemail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("RI_PUEmail");
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblRiDetails2021bk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRI_Details_2021BK");

            entity.Property(e => e.BillingRi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Billing_RI");
            entity.Property(e => e.Company).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(10);
            entity.Property(e => e.ExternalEntity).HasMaxLength(10);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.RiAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RI_Address");
            entity.Property(e => e.RiBuildingName)
                .HasMaxLength(100)
                .HasColumnName("RI_BuildingName");
            entity.Property(e => e.RiCoRegNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RI_CoRegNum");
            entity.Property(e => e.RiFullName)
                .HasMaxLength(100)
                .HasColumnName("RI_FullName");
            entity.Property(e => e.RiId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RI_Id");
            entity.Property(e => e.RiPostalCode)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("RI_PostalCode");
            entity.Property(e => e.RiPuemail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("RI_PUEmail");
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblSysNotice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSysNotice");

            entity.Property(e => e.Display)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblUom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblUOM");

            entity.Property(e => e.SDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("sDescription");
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SNo");
            entity.Property(e => e.Uom)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<TblVehicleLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_VehicleLocation");

            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblVendorOtherDetail>(entity =>
        {
            entity.HasKey(e => e.Sno);

            entity.ToTable("tblVendorOtherDetails");

            entity.Property(e => e.Sno).HasColumnName("SNo");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Designation).HasMaxLength(255);
            entity.Property(e => e.EPrno)
                .HasMaxLength(20)
                .HasColumnName("ePRNo");
            entity.Property(e => e.ExportControl).HasMaxLength(10);
            entity.Property(e => e.ExportReasons).HasMaxLength(255);
            entity.Property(e => e.GstregisterNumber)
                .HasMaxLength(255)
                .HasColumnName("GSTRegisterNumber");
            entity.Property(e => e.Gstregistered)
                .HasMaxLength(10)
                .HasColumnName("GSTRegistered");
            entity.Property(e => e.IsDeleted).HasMaxLength(10);
            entity.Property(e => e.IsDraft).HasMaxLength(10);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.LeadTime).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PaymentTerm).HasMaxLength(255);
            entity.Property(e => e.QuotationExpiry).HasColumnType("datetime");
            entity.Property(e => e.QuotationRefNoLoano)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("QuotationRefNoLOANo");
            entity.Property(e => e.RegulatoryControl).HasMaxLength(10);
            entity.Property(e => e.RegulatoryReasons).HasMaxLength(255);
            entity.Property(e => e.ShippingTerm).HasMaxLength(255);
            entity.Property(e => e.VendorId)
                .HasMaxLength(255)
                .HasColumnName("VendorID");
            entity.Property(e => e.WarrantyPeriod).HasMaxLength(255);
        });

        modelBuilder.Entity<TblVendorPrice>(entity =>
        {
            entity.HasKey(e => e.Sno);

            entity.ToTable("tblVendorPrice");

            entity.Property(e => e.Sno).HasColumnName("SNo");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EPrno)
                .HasMaxLength(20)
                .HasColumnName("ePRNo");
            entity.Property(e => e.IsDeleted).HasMaxLength(10);
            entity.Property(e => e.NoQuote).HasMaxLength(10);
            entity.Property(e => e.Price).HasMaxLength(50);
            entity.Property(e => e.TotalPrice).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(255)
                .HasColumnName("VendorID");
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
