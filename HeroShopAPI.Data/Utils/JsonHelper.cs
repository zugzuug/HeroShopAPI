
namespace HeroShopAPI.Data.Utils
{    
    internal class JsonHelper
    {
        static string fileName = "ich_will.mp3";
        static string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

        public static string ReadJsonFile()
        {
            string json = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    json = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {                
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
            }
            return json;
        }
    }
}
