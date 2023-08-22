using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblErrorLog
{
    public int Sno { get; set; }

    public DateTime? TimeOfError { get; set; }

    public string? ErrMessage { get; set; }

    public string? LoginName { get; set; }

    public string? EPrno { get; set; }
}
