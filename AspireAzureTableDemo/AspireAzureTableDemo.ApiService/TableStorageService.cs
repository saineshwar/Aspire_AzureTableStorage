using AspireAzureTableDemo.ApiService.Models;
using Azure.Data.Tables;

namespace AspireAzureTableDemo.ApiService
{
    public class TableStorageService
    {
        private readonly TableServiceClient _tableServiceClient;
        private readonly TableClient _tableClient;


        public TableStorageService(TableServiceClient tableServiceClient)
        {
            _tableServiceClient = tableServiceClient;
            _tableClient = _tableServiceClient.GetTableClient("Inventory");
            _tableClient.CreateIfNotExists();
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            try
            {
                var containerClient = await _tableClient.AddEntityAsync<Inventory>(inventory);
                 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Inventory?> GetInventoryAsync(string partitionKey, string rowKey)
        {
            return await _tableClient.GetEntityAsync<Inventory>(partitionKey, rowKey);
        }


        public async Task<IEnumerable<Inventory>> GetAllInventorysAsync()
        {
            List<Inventory> Inventorys = new();
            await foreach (var entity in _tableClient.QueryAsync<Inventory>())
            {
                Inventorys.Add(entity);
            }
            return Inventorys;
        }
    }
}
