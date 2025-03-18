namespace AspireAzureTableDemo.ApiService.Models
{
    public class InventoryRequest
    {
        public string ItemName { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string Quantity { get; set; } = default!;
        public string Price { get; set; } = default!;
        public string Supplier { get; set; } = default!;
    }
}
