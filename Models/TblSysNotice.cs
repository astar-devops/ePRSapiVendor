using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblSysNotice
{
    public int Sno { get; set; }

    public string? NoticeMsg { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string Display { get; set; } = null!;
}
