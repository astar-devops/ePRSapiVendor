using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblLogLogin
{
    public int Sno { get; set; }

    public string LoginId { get; set; } = null!;

    public DateTime? LoginDate { get; set; }

    public string? BrowserType { get; set; }

    public string? Ipaddress { get; set; }
}
