using BumbaApiGraphQL.Data;
using BumbaApiGraphQL.Models;

namespace BumbaApiGraphQL.Types;

public class Mutation
{
    #region Cemiterio
    public async Task<Cemiterio> CreateUpdateCemiterio([Service] DataContext ctx, Cemiterio input)
    {
        try
        {
            if (input.Id == 0)
                ctx.Cemiterios?.Add(input);
            else
                ctx.Cemiterios?.Update(input);
            await ctx.SaveChangesAsync();
            return input;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar ou cadastrar a entidade. {ex.Message}");
        }
    }

    public async Task<bool> DeleteCemiterio([Service] DataContext ctx, int id)
    {
        try
        {
            var exist = await ctx.Cemiterios!.FindAsync(id);
            if (exist is null) return false;
            ctx.Cemiterios!.Remove(exist);
            await ctx.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao deletar a entidade. {ex.Message}");
        }
    }
    #endregion

    #region Defunto
    public async Task<Defunto> CreateUpdateDefunto([Service] DataContext ctx, Defunto input)
    {
        try
        {
            if (input.Id == 0)
                ctx.Defuntos?.Add(input);
            else
                ctx.Defuntos?.Update(input);
            await ctx.SaveChangesAsync();
            return input;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar ou cadastrar a entidade. {ex.Message}");
        }
    }

    public async Task<bool> DeleteDefunto([Service] DataContext ctx, int id)
    {
        try
        {
            var exist = await ctx.Defuntos!.FindAsync(id);
            if (exist is null) return false;
            ctx.Defuntos!.Remove(exist);
            await ctx.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao deletar a entidade. {ex.Message}");
        }
    }
    #endregion

    #region Municipio
    public async Task<Municipio> CreateUpdateMunicipio([Service] DataContext ctx, Municipio input)
    {
        try
        {
            if (input.Id == 0)
                ctx.Municipios?.Add(input);
            else
                ctx.Municipios?.Update(input);
            await ctx.SaveChangesAsync();
            return input;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar ou cadastrar a entidade. {ex.Message}");
        }
    }

    public async Task<bool> DeleteMunicipio([Service] DataContext ctx, int id)
    {
        try
        {
            var exist = await ctx.Municipios!.FindAsync(id);
            if (exist is null) return false;
            ctx.Municipios!.Remove(exist);
            await ctx.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao deletar a entidade. {ex.Message}");
        }
    }
    #endregion

    #region Provincia
    public async Task<Provincia> CreateUpdateProvincia([Service] DataContext ctx, Provincia input)
    {
        try
        {
            if (input.Id == 0)
                ctx.Provincias?.Add(input);
            else
                ctx.Provincias?.Update(input);
            await ctx.SaveChangesAsync();
            return input;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar ou cadastrar a entidade. {ex.Message}");
        }
    }

    public async Task<bool> DeleteProvincia([Service] DataContext ctx, int id)
    {
        try
        {
            var exist = await ctx.Provincias!.FindAsync(id);
            if (exist is null) return false;
            ctx.Provincias!.Remove(exist);
            await ctx.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao deletar a entidade. {ex.Message}");
        }
    }
    #endregion

    #region User
    public async Task<User> CreateUpdateUser([Service] DataContext ctx, User input)
    {
        try
        {
            if (input.Id == 0)
                ctx.User?.Add(input);
            else
                ctx.User?.Update(input);
            await ctx.SaveChangesAsync();
            return input;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar ou cadastrar a entidade. {ex.Message}");
        }
    }

    public async Task<bool> DeleteUser([Service] DataContext ctx, int id)
    {
        try
        {
            var exist = await ctx.User!.FindAsync(id);
            if (exist is null) return false;
            ctx.User!.Remove(exist);
            await ctx.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao deletar a entidade. {ex.Message}");
        }
    }
    #endregion

    #region Utente
    public async Task<Utente> CreateUpdateUtente([Service] DataContext ctx, Utente input)
    {
        try
        {
            if (input.Id == 0)
                ctx.Utentes?.Add(input);
            else
                ctx.Utentes?.Update(input);
            await ctx.SaveChangesAsync();
            return input;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar ou cadastrar a entidade. {ex.Message}");
        }
    }

    public async Task<bool> DeleteUtente([Service] DataContext ctx, int id)
    {
        try
        {
            var exist = await ctx.Utentes!.FindAsync(id);
            if (exist is null) return false;
            ctx.Utentes!.Remove(exist);
            await ctx.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao deletar a entidade. {ex.Message}");
        }
    }
    #endregion

    #region Appointment
    public async Task<Appointment> CreateUpdateAppointment([Service] DataContext ctx, Appointment input)
    {
        try
        {
            if (input.Id == 0)
                ctx.Appointments?.Add(input);
            else
                ctx.Appointments?.Update(input);
            await ctx.SaveChangesAsync();
            return input;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar ou cadastrar a entidade. {ex.Message}");
        }
    }

    public async Task<bool> DeleteAppointment([Service] DataContext ctx, int id)
    {
        try
        {
            var exist = await ctx.Appointments!.FindAsync(id);
            if (exist is null) return false;
            ctx.Appointments!.Remove(exist);
            await ctx.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao deletar a entidade. {ex.Message}");
        }
    }
    #endregion

    #region Transladacao
    public async Task<Transladacao> CreateUpdateTransladacao([Service] DataContext ctx, Transladacao input)
    {
        try
        {
            if (input.Id == 0)
                ctx.Transladacao?.Add(input);
            else
                ctx.Transladacao?.Update(input);
            await ctx.SaveChangesAsync();
            return input;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar ou cadastrar a entidade. {ex.Message}");
        }
    }

    public async Task<bool> DeleteTransladacao([Service] DataContext ctx, int id)
    {
        try
        {
            var exist = await ctx.Transladacao!.FindAsync(id);
            if (exist is null) return false;
            ctx.Transladacao!.Remove(exist);
            await ctx.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao deletar a entidade. {ex.Message}");
        }
    }
    #endregion
}
