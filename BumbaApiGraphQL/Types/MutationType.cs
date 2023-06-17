using BumbaApiGraphQL.Data;
using BumbaApiGraphQL.Models;

namespace BumbaApiGraphQL.Types;

public class MutationType
{
    public async Task<User> AddUser([Service] DataContext ctx, User input)
    {
        ctx.User.Add(input);
        await ctx.SaveChangesAsync();
        return input;
    }
}
