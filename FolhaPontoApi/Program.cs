using FolhaPontoApi.data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FolhaPontoDbContext>(options=>options.UseMySql(connectionString, new MySqlServerVersion(new Version(8,0,36))));

var app = builder.Build();
// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.Run();
