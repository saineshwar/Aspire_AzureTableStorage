var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

// Add for Azure Table Storage

var blobs = builder.AddConnectionString("blobs");

var apiService = builder.AddProject<Projects.AspireAzureTableDemo_ApiService>("apiservice")
    .WithReference(blobs);

// Add for Azure Table Storage

builder.AddProject<Projects.AspireAzureTableDemo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
