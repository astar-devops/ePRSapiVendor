using System;
using System.Collections.Generic;

namespace ePRS_VendorAPI.Models;

public partial class TblEprrecord
{
    public int Sno { get; set; }

    public string EPrno { get; set; } = null!;

    public string? Sapprno { get; set; }

    public string? Sappono { get; set; }

    public string? CreatorName { get; set; }

    public string? CreatorId { get; set; }

    public string? RequestorName { get; set; }

    public string? RequestorId { get; set; }

    public string? ContactNo { get; set; }

    public string? CreationDate { get; set; }

    public string? RequestType { get; set; }

    public string? Ri { get; set; }

    public string? EPrtype { get; set; }

    public string? EPrtitle { get; set; }

    public int? ProjectCodesSno { get; set; }

    public string? PurchasingGroup { get; set; }

    public string? DeliveryDate { get; set; }

    public string? ReasonOfPurchase { get; set; }

    public string? SpecialInstructions { get; set; }

    public string? DeliveryInstructions { get; set; }

    public string? DeclareLabSpace { get; set; }

    public string? ImrelabCoord { get; set; }

    public string? ImrelabNo { get; set; }

    public string? ImrelabLoc { get; set; }

    public string? DeclareInterest { get; set; }

    public string? TotalLineItems { get; set; }

    public string? SummaryItemTotal { get; set; }

    public DateTime? EPrcreatedDateTime { get; set; }

    public string? ReasonOfWaiver { get; set; }

    public string? ChoiceReasonForLqw { get; set; }

    public string? Lqwapprover { get; set; }

    public string? Ecapprover { get; set; }

    public string? Rcapprover { get; set; }

    public int? ApoconfigSno { get; set; }

    public DateTime? ApoqueryDate { get; set; }

    public DateTime? ApoqueryRepliedDate { get; set; }

    public string? ApoqueryFlag { get; set; }

    public string? ApolastActionBy { get; set; }

    public string? Apoapprover { get; set; }
}
