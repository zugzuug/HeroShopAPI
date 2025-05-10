using Microsoft.AspNetCore.Mvc;
//using HeroShopAPI.Business;
using System.Text;

namespace HeroShopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        static string _connStr = WebApplication.CreateBuilder().Configuration.GetConnectionString("DefaultConnection") ?? "ConnectionString not found";

        [HttpGet]
        [Route("GetAllItems")]
        public IActionResult GetAllItems()
        {
            string response = "GetAllItems() called successfully.";

            return new JsonResult(response);
        }

        [HttpGet]
        [Route("GetItemDetail")]
        public IActionResult GetItemDetail(int itemId)
        {
            return new JsonResult($"ItemID: {itemId}");
        }

        [HttpGet]
        [Route("GetRates")]
        public IActionResult GetRates()
        {
            StringBuilder sb = new StringBuilder();
            int totalSeconds = 0;
            foreach (string line in System.IO.File.ReadAllLines($"E:\\minutes2.txt"))
            {
                if (line.Contains("s") && !line.Contains("m")) //only contains seconds
                {
                    totalSeconds += Convert.ToInt32(line.Replace("s", "").Trim());
                    //sb.AppendLine(line.Replace("s", "").Trim());
                }
                else if (!line.Contains("s") && line.Contains("m")) //only contains minutes
                {
                    totalSeconds += (Convert.ToInt32(line.Replace("m", "").Trim()) * 60);
                    //sb.AppendLine((Convert.ToInt32(line.Replace("m", "").Trim())*60).ToString());
                }
                else if (line.Contains("s") && line.Contains("m")) //contains both
                {
                    string newLine = line.Replace("s", "");
                    newLine = newLine.Replace("m", ",");
                    int[] parts = newLine.Split(',').Select(int.Parse).ToArray();
                    totalSeconds += ((parts[0] * 60) + parts[1]);
                    //sb.AppendLine(((parts[0] * 60) + parts[1]).ToString());
                }
                else { continue; }
            }

            int totalHours = totalSeconds / 3600;
            if (totalHours > 0)
            {
                totalSeconds = totalSeconds - (totalHours * 3600);
            }
            int totalMinutes = totalSeconds / 60;
            if (totalMinutes > 0)
            {
                totalSeconds = totalSeconds - (totalMinutes * 60);
            }

            return new JsonResult($"{totalHours}h {totalMinutes}m {totalSeconds}s");
        }
        
    }
}
