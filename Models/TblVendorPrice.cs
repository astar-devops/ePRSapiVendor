using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblVendorPrice
{
    public int Sno { get; set; }

    public string EPrno { get; set; } = null!;

    public int? ItemIndex { get; set; }

    public string? Price { get; set; }

    public string? TotalPrice { get; set; }

    public string? Remarks { get; set; }

    public string? VendorName { get; set; }

    public string? VendorId { get; set; }

    public string? NoQuote { get; set; }

    public string? IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }
}
