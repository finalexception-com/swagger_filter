using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Product_manager.data;
using Product_manager.Reposiroties;
using Product_manager.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase(Guid.NewGuid().ToString()));

builder.Services.AddScoped<ICategoryRepository, CategoryServices>();
builder.Services.AddScoped<IProductRepository, ProductServices>();
builder.Services.AddScoped<IClientRepository, ClientServices>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Set up a DocInclusionPredicate to filter out DELETE operations
    c.DocInclusionPredicate((docName, apiDesc) =>
    {
        // Exclude DELETE operations
        var httpMethod = apiDesc.HttpMethod?.ToUpper();
        return httpMethod != "POST";
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
