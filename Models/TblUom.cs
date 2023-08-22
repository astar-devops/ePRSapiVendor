using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblUom
{
    public int Sno { get; set; }

    public string Uom { get; set; } = null!;

    public string? SDescription { get; set; }
}
