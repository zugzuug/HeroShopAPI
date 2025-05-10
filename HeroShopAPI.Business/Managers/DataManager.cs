using HeroShopAPI.Data;

namespace HeroShopAPI.Business.Managers
{
    public class DataManager
    {
        private bool useLocal = true;
        private string connnectionString;
        private string localJsonDBPath;

        public DataManager(string connectionString, string localJsonDBPath, bool useLocal = true)
        {
            connnectionString = connectionString;
            this.localJsonDBPath = localJsonDBPath;
            this.useLocal = useLocal;
        }

        public List<Item> GetItems()
        {
            if (useLocal)
            {
                return GetItemsFromLocal();
            }
            else
            {
                return GetItemsFromDB();
            }
        }

        private List<Item> GetItemsFromLocal()
        {
            DataAccess da = new DataAccess(localJsonDBPath, true);
            return da.GetItems();
        }

        private List<Item> GetItemsFromDB()
        {
            throw new NotImplementedException("Database access not implemented yet.");
        }

        public Item GetItemDetail(int itemId)
        {
            throw new NotImplementedException("GetItemDetail not implemented yet.");
        }
    }
}
