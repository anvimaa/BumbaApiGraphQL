using BumbaApiGraphQL.Data;
using BumbaApiGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BumbaApiGraphQL.Types;

public class Query
{
    #region User
    [UseFiltering]
    public async Task<List<User>> GetUsersAsync([Service] DataContext context) => await context.User!.ToListAsync();
    #endregion

    #region Provincia
    [UseFiltering]
    public async Task<List<Provincia>> GetProvinciasAsync([Service] DataContext context) => await context.Provincias!.ToListAsync();
    #endregion

    #region Municipio
    [UseFiltering]
    public async Task<List<Municipio>> GetMunicipiosAsync([Service] DataContext context) => await context.Municipios!.ToListAsync();
    #endregion

    #region Utente
    [UseFiltering]
    public async Task<List<Utente>> GetUtentesAsync([Service] DataContext context) => await context.Utentes!.ToListAsync();
    #endregion

    #region Cemiterio
    [UseFiltering]
    public async Task<List<Cemiterio>> GetCemiteriosAsync([Service] DataContext context) => await context.Cemiterios!.ToListAsync();
    #endregion

    #region Defunto
    [UseFiltering]
    public async Task<List<Defunto>> GetDefuntosAsync([Service] DataContext context) => await context.Defuntos!.ToListAsync();
    #endregion
}
