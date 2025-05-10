using System;
using System.Collections.Generic;

namespace HeroShopAPI.Data.Models;

public partial class Price
{
    public int PriceId { get; set; }

    public int ItemId { get; set; }

    public decimal Price1 { get; set; }

    public DateTime? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ICollection<PriceSheet> PriceSheets { get; set; } = new List<PriceSheet>();
}
