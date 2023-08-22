using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblLogonSession
{
    public int Sno { get; set; }

    public string EPrno { get; set; } = null!;

    public string LoginId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public DateTime LoginDate { get; set; }

    public string Ipaddress { get; set; } = null!;

    public DateTime? LogoutDate { get; set; }
}
