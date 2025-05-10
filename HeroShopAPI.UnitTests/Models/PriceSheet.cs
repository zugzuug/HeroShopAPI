using System;
using System.Collections.Generic;

namespace HeroShopAPI.Data.Models;

public partial class PriceSheet
{
    public int PriceSheetId { get; set; }

    public int PriceId { get; set; }

    public DateTime? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Price Price { get; set; } = null!;
}
