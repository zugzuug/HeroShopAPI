using System;
using System.Collections.Generic;

namespace HeroShopAPI.Data.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public decimal? Weight { get; set; }

    public DateTime? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();
}
