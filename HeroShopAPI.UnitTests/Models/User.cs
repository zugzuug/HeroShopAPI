using System;
using System.Collections.Generic;

namespace HeroShopAPI.Data.Models;

public partial class User
{
    public int UserId { get; set; }

    public DateTime? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
