using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblRequestorDetail
{
    public int SNo { get; set; }

    public string Ri { get; set; } = null!;

    public string EPrno { get; set; } = null!;

    public string RequestorEmail { get; set; } = null!;

    public string? ContactNo { get; set; }
}
