using BumbaApiGraphQL.Data;
using BumbaApiGraphQL.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("amudb");
builder.Services.AddDbContext<DataContext>(o => o.UseSqlite(connectionString).UseLazyLoadingProxies());

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowedOrigins",
            policy =>
            {
                policy.WithOrigins("*") // note the port is included 
            .AllowAnyHeader()
            .AllowAnyMethod();
            });
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.UseCors("AllowedOrigins");
app.MapGraphQL();

app.Run();
