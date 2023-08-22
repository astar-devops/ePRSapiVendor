using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblLoginAdmin
{
    public int Sno { get; set; }

    public string LoginId { get; set; } = null!;

    public string LoginPassword { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string? Email { get; set; }
}
