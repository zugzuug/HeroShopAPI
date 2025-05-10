using System;
using System.Collections.Generic;

namespace HeroShopAPI.Data.Models;

public partial class Logging
{
    public int LogId { get; set; }

    public string Message { get; set; } = null!;

    public string? StackTrace { get; set; }

    public int LoggingTypeId { get; set; }

    public string LogType { get; set; } = null!;

    public int? UserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual LoggingType LoggingType { get; set; } = null!;
}
