using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblAdditionalItem
{
    public int Sno { get; set; }

    public string EPrno { get; set; } = null!;

    public string? VendorId { get; set; }

    public string VendorName { get; set; } = null!;

    public string ItemDesc { get; set; } = null!;

    public string? AddItemDesc { get; set; }

    public string Qty { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string Price { get; set; } = null!;

    public string Sgdprice { get; set; } = null!;

    public string? TotalPrice { get; set; }

    public string? DeliveryDate { get; set; }

    public string? Remarks { get; set; }

    public string? Uom { get; set; }
}
