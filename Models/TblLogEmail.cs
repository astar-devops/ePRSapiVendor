using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblLogEmail
{
    public int Sno { get; set; }

    public string Subject { get; set; } = null!;

    public DateTime? SentDate { get; set; }

    public string? Addressee { get; set; }
}
