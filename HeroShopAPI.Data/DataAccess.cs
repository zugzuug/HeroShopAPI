namespace HeroShopAPI.Data
{
    public class DataAccess
    {
        public static string GetItems(string connectionString)
        {
            return $"DataAccess: {connectionString}";
        }

    }
}
