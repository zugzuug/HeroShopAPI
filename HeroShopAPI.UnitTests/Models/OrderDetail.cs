using System;
using System.Collections.Generic;

namespace HeroShopAPI.Data.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int OrderId { get; set; }

    public virtual Order Order { get; set; } = null!;
}
