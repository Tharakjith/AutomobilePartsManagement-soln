using System;
using System.Collections.Generic;

namespace AutomobilePartsManagement.Models;

public partial class CompatibleCarModel
{
    public int CompatibilityId { get; set; }

    public int PartId { get; set; }

    public int CarModelId { get; set; }

    public virtual CarModel CarModel { get; set; } = null!;

    [System.Text.Json.Serialization.JsonIgnore]
    public virtual AutoPart Part { get; set; } = null!;
}
