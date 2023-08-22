using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblRiDetails2021bk
{
    public int Sno { get; set; }

    public string RiId { get; set; } = null!;

    public string RiFullName { get; set; } = null!;

    public string? RiAddress { get; set; }

    public string? RiBuildingName { get; set; }

    public string? RiPostalCode { get; set; }

    public string? RiPuemail { get; set; }

    public string? Country { get; set; }

    public string? BillingRi { get; set; }

    public string? RiCoRegNum { get; set; }

    public string? ExternalEntity { get; set; }

    public string? Company { get; set; }

    public string? Notes { get; set; }
}
