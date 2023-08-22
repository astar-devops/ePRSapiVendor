using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblVendorOtherDetail
{
    public int Sno { get; set; }

    public string EPrno { get; set; } = null!;

    public string? VendorId { get; set; }

    public string? Currency { get; set; }

    public DateTime? QuotationExpiry { get; set; }

    public string? PaymentTerm { get; set; }

    public string? ShippingTerm { get; set; }

    public string? LeadTime { get; set; }

    public string? WarrantyPeriod { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public string? Gstregistered { get; set; }

    public string? GstregisterNumber { get; set; }

    public string? ExportControl { get; set; }

    public string? ExportReasons { get; set; }

    public string? RegulatoryControl { get; set; }

    public string? RegulatoryReasons { get; set; }

    public string? Notes { get; set; }

    public string? IsDraft { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? IsDeleted { get; set; }

    public string? QuotationRefNoLoano { get; set; }
}
