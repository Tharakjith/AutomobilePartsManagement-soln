using System;
using System.Collections.Generic;

namespace AutomobilePartsManagement.Models;

public partial class ManufacturingCompany
{
    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string? Country { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]
    public virtual ICollection<AutoPart> AutoParts { get; set; } = new List<AutoPart>();
}
