using BumbaApiGraphQL.Data;
using BumbaApiGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BumbaApiGraphQL.Types;

public class QueryType
{
    public async Task<List<User>> GetUsersAsync([Service] DataContext context) => await context.User.ToListAsync();

    public async Task<User?> GetUserAsync([Service] DataContext context, int id) => await context.User.FindAsync(id);
}
