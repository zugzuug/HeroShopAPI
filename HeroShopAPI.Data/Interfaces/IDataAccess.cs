using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroShopAPI.Data.Interfaces
{
    public interface IDataAccess
    {
        List<Item> GetItems();
    }
}
