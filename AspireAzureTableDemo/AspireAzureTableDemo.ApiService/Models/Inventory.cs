using Azure;
using Azure.Data.Tables;

namespace AspireAzureTableDemo.ApiService.Models
{
    public class Inventory : ITableEntity
    {
        public string PartitionKey { get; set; } = default!;
        public string RowKey { get; set; } = default!;
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; } = ETag.All;

        // Custom Properties
        public string ItemName { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string Quantity { get; set; } = default!;
        public string Price { get; set; } = default!;
        public string Supplier { get; set; } = default!;
        public string LastUpdated { get; set; } = DateTime.UtcNow.ToString("yyyy-MM-dd");

    }
}
