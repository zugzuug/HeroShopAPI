using HeroShopAPI.Business.Factories;
using HeroShopAPI.Business.Managers;
using Microsoft.AspNetCore.Mvc;
//using HeroShopAPI.Business;
using System.Text;

namespace HeroShopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ItemsController : ControllerBase
    {        
        private readonly string _connectionString;
        private readonly string _jsonPath;
        public ItemsController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configuration["DataFiles:JsonFilePath"]);            
        }

        [HttpGet]
        [Route("GetAllItems")]
        public IActionResult GetAllItems()
        {
            DataManager dm = DataManagerFactory.GetDataManager(_connectionString, _jsonPath, true);
            var items = dm.GetItems();
            var response = new
            {
                Status = "Success",
                Message = "Items retrieved successfully.",
                Data = items
            };
            return new JsonResult(response);
        }

        [HttpGet]
        [Route("GetItemDetail")]
        public IActionResult GetItemDetail(int itemId)
        {
            return new JsonResult($"Not Implemented, Requested ItemID: {itemId}");
        }
    }
}
