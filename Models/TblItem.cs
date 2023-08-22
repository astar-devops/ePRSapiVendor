using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblItem
{
    public string EPrno { get; set; } = null!;

    public int ItemIndex { get; set; }

    public string? VendorName { get; set; }

    public int? LineItemNo { get; set; }

    public string ItemDesc { get; set; } = null!;

    public string? AddItemDesc { get; set; }

    public string Qty { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string Price { get; set; } = null!;

    public string Sgdprice { get; set; } = null!;

    public string DeliveryDate { get; set; } = null!;

    public string? TotalPrice { get; set; }
}
