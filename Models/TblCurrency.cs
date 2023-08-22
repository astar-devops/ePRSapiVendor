using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblCurrency
{
    public int Sno { get; set; }

    public string Currency { get; set; } = null!;

    public string? SDescription { get; set; }
}
