using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblHotaAn
{
    public int Sno { get; set; }

    public int QnsId { get; set; }

    public string EPrno { get; set; } = null!;

    public string VendorId { get; set; } = null!;

    public string Ans { get; set; } = null!;

    public string? AnsDetails { get; set; }
}
