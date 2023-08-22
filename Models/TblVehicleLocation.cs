using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblVehicleLocation
{
    public int Sno { get; set; }

    public string Latitude { get; set; } = null!;

    public string Longitude { get; set; } = null!;

    public DateTime TimeStamp { get; set; }

    public string? Address { get; set; }

    public string? ShortAddress { get; set; }
}
