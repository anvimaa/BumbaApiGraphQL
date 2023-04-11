using BumbaApiGraphQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SQLServer");

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapGraphQL();

app.Run();
