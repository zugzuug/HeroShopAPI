using System;
using System.Collections.Generic;

namespace HeroShopAPI.Data.Models;

public partial class LoggingType
{
    public int LoggingTypeId { get; set; }

    public int LoggingId { get; set; }

    public string Type { get; set; } = null!;

    public bool IsError { get; set; }

    public string Description { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Logging> Loggings { get; set; } = new List<Logging>();
}
