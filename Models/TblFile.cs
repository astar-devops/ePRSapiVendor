using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblFile
{
    public int Sno { get; set; }

    public string? EPrno { get; set; }

    public string? OriginalFileName { get; set; }

    public string? RenamedFileName { get; set; }

    public string? Remarks { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedBy { get; set; }

    public string? SDelete { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DocType { get; set; }
}
