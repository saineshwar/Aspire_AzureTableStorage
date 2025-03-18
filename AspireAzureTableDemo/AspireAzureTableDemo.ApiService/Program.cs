using AspireAzureTableDemo.ApiService;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

builder.AddAzureTableClient("blobs");
// Add services to the container.
builder.Services.AddProblemDetails();

// Add API Documentation
builder.Services.AddSwaggerGen();

// Add controllers services
builder.Services.AddControllers();


builder.Services.AddScoped<TableStorageService>();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// MapControllers is used to map the controllers to the application.
app.MapControllers();

// Register the Swagger generator and the Swagger UI middlewares
app.UseSwagger();

// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwaggerUI();

app.MapDefaultEndpoints();

app.Run();

