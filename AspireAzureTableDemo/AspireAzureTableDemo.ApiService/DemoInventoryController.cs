using AspireAzureTableDemo.ApiService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspireAzureTableDemo.ApiService
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoInventoryController : ControllerBase
    {
        private readonly TableStorageService _tableStorageService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableStorageService"></param>
        public DemoInventoryController(TableStorageService tableStorageService)
        {
            _tableStorageService = tableStorageService;
        }

        [HttpPost]
        public async Task<IActionResult> AddInventory(InventoryRequest inventoryRequest)
        {

            var inventory = new Inventory
            {
                PartitionKey = "Warehouse",
                RowKey = Guid.NewGuid().ToString(),
                ItemName = inventoryRequest.ItemName,
                Category = inventoryRequest.Category,
                Quantity = inventoryRequest.Quantity,
                Price = inventoryRequest.Price,
                Supplier = inventoryRequest.Supplier,
                LastUpdated = DateTime.UtcNow.ToString("yyyy-MM-dd"),
                Timestamp = DateTimeOffset.UtcNow
            };  

            await _tableStorageService.AddInventoryAsync(inventory);
            return Ok();
        }

        [HttpGet("{partitionKey}/{rowKey}")]
        public async Task<IActionResult> GetInventory(string partitionKey, string rowKey)
        {
            var inventory = await _tableStorageService.GetInventoryAsync(partitionKey, rowKey);
            if (inventory == null) return NotFound();
            return Ok(inventory);
        }   

        [HttpGet]
        public async Task<IActionResult> GetAllInventories()
        {
            var inventories = await _tableStorageService.GetAllInventorysAsync();
            return Ok(inventories);
        }
    }
}
