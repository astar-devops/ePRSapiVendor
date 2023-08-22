using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblHotaQn
{
    public int Sno { get; set; }

    public int QnsOrder { get; set; }

    public string Qns { get; set; } = null!;

    public DateTime AddedOn { get; set; }

    public string AddedBy { get; set; } = null!;

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? IsDeleted { get; set; }
}
