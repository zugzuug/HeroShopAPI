using System;
using System.Collections.Generic;

namespace HeroShopAPI.Data.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int ItemId { get; set; }

    public int Count { get; set; }

    public DateTime? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Item Item { get; set; } = null!;
}
