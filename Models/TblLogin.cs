using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblLogin
{
    public int Sno { get; set; }

    public string VendorName { get; set; } = null!;

    public string LoginId { get; set; } = null!;

    public string LoginPassword { get; set; } = null!;

    public DateTime Expired { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string Ri { get; set; } = null!;

    public string? EPrno { get; set; }

    public string? IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }

    public int? LoginTries { get; set; }

    public string? Remarks { get; set; }

    public string? VendorCode { get; set; }
}
