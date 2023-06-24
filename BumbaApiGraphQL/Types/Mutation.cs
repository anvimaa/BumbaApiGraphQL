using BumbaApiGraphQL.Data;
using BumbaApiGraphQL.Models;

namespace BumbaApiGraphQL.Types;

public class Mutation
{
    #region User
    public async Task<User> CreateUser([Service] DataContext ctx, User input)
    {
        ctx.User?.Add(input);
        await ctx.SaveChangesAsync();
        return input;
    }
    #endregion

    #region Provincia
    public async Task<Provincia> CreateProvincia([Service] DataContext ctx, Provincia input)
    {
        ctx.Provincias?.Add(input);
        await ctx.SaveChangesAsync();
        return input;
    }

    public async Task<Provincia> UpdateProvincia([Service] DataContext ctx, Provincia input)
    {
        ctx.Provincias?.Update(input);
        await ctx.SaveChangesAsync();
        return input;
    }

    public async Task<bool> DeleteProvincia([Service] DataContext ctx, int id)
    {
        var exist = await ctx.Provincias!.FindAsync(id);
        if (exist is null) return false;
        ctx.Provincias!.Remove(exist);
        await ctx.SaveChangesAsync();
        return true;
    }
    #endregion

    #region Municipio
    public async Task<Municipio> CreateMunicipio([Service] DataContext ctx, Municipio input)
    {
        ctx.Municipios?.Add(input);
        await ctx.SaveChangesAsync();
        return input;
    }

    public async Task<Municipio> UpdateMunicipio([Service] DataContext ctx, Municipio input)
    {
        ctx.Municipios?.Update(input);
        await ctx.SaveChangesAsync();
        return input;
    }

    public async Task<bool> DeleteMunicipio([Service] DataContext ctx, int id)
    {
        var exist = await ctx.Municipios!.FindAsync(id);
        if (exist is null) return false;
        ctx.Municipios!.Remove(exist);
        await ctx.SaveChangesAsync();
        return true;
    }
    #endregion

    #region Utente
    public async Task<Utente> CreateUtente([Service] DataContext ctx, Utente input)
    {
        ctx.Utentes?.Add(input);
        await ctx.SaveChangesAsync();
        return input;
    }

    public async Task<Utente> UpdateUtente([Service] DataContext ctx, Utente input)
    {
        ctx.Utentes?.Update(input);
        await ctx.SaveChangesAsync();
        return input;
    }

    public async Task<bool> DeleteUtente([Service] DataContext ctx, int id)
    {
        var exist = await ctx.Utentes!.FindAsync(id);
        if (exist is null) return false;
        ctx.Utentes!.Remove(exist);
        await ctx.SaveChangesAsync();
        return true;
    }
    #endregion

    #region Proprietario
    public async Task<Proprietario> CreateProprietario([Service] DataContext ctx, Proprietario input)
    {
        ctx.Proprietarios?.Add(input);
        await ctx.SaveChangesAsync();
        return input;
    }

    public async Task<Proprietario> UpdateProprietario([Service] DataContext ctx, Proprietario input)
    {
        ctx.Proprietarios?.Update(input);
        await ctx.SaveChangesAsync();
        return input;
    }

    public async Task<bool> DeleteProprietario([Service] DataContext ctx, int id)
    {
        var exist = await ctx.Proprietarios!.FindAsync(id);
        if (exist is null) return false;
        ctx.Proprietarios!.Remove(exist);
        await ctx.SaveChangesAsync();
        return true;
    }
    #endregion
}
