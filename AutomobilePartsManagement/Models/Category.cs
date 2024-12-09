using System;
using System.Collections.Generic;

namespace AutomobilePartsManagement.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    [System.Text.Json.Serialization.JsonIgnore]
    public virtual ICollection<AutoPart> AutoParts { get; set; } = new List<AutoPart>();
}
