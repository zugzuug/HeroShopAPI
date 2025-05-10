using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroShopAPI.Common.Interfaces
{
    public interface IItem
    {
        int ItemId { get; set; }
        int CategoryId { get; set; }
        string Category { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string? Disclaimer { get; set; }
        double Weight { get; set; }
        decimal Price { get; set; }
        string IconUrl { get; set; }
    }
}
