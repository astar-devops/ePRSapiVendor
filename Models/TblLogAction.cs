using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblLogAction
{
    public int Sno { get; set; }

    public string LoginId { get; set; } = null!;

    public DateTime? ActionDate { get; set; }

    public string? ActionDesc { get; set; }

    public string? Ipaddress { get; set; }
}
