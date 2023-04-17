using BumbaApiGraphQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var connectionString = builder.Configuration.GetConnectionString("todos") ?? "Data Source=todos.db";
builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(connectionString));

var app = builder.Build();

app.MapGraphQL();

app.Run();
