using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroShopAPI.Business.Managers;

namespace HeroShopAPI.Business.Factories
{
    public class DataManagerFactory
    {
        public static DataManager GetDataManager(string connectionString, string localJsonDBPath, bool useLocal = true)
        {
            return new DataManager(connectionString, localJsonDBPath, useLocal);
        }
    }    
}
