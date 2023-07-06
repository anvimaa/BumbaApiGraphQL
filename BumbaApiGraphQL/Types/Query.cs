using BumbaApiGraphQL.Data;
using BumbaApiGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BumbaApiGraphQL.Types;

public class Query
{
    #region User
    [UseSorting]
    [UseFiltering]
    public async Task<List<User>> GetUsersAsync([Service] DataContext context) => await context.User!.ToListAsync();
    #endregion

    #region Provincia
    [UseSorting]
    [UseFiltering]
    public async Task<List<Provincia>> GetProvinciasAsync([Service] DataContext context) => await context.Provincias!.ToListAsync();
    #endregion

    #region Municipio
    [UseSorting]
    [UseFiltering]
    public async Task<List<Municipio>> GetMunicipiosAsync([Service] DataContext context) => await context.Municipios!.ToListAsync();
    #endregion

    #region Utente
    [UseSorting]
    [UseFiltering]
    public async Task<List<Utente>> GetUtentesAsync([Service] DataContext context) => await context.Utentes!.ToListAsync();
    #endregion

    #region Cemiterio
    [UseSorting]
    [UseFiltering]
    public async Task<List<Cemiterio>> GetCemiteriosAsync([Service] DataContext context) => await context.Cemiterios!.ToListAsync();
    #endregion

    #region Defunto
    [UseSorting]
    [UseFiltering]
    public async Task<List<Defunto>> GetDefuntosAsync([Service] DataContext context) => await context.Defuntos!.ToListAsync();
    #endregion

    #region Appointments
    [UseSorting]
    [UseFiltering]
    public async Task<List<Appointment>> GetAppointmentsAsync([Service] DataContext context) => await context.Appointments!.ToListAsync();
    #endregion

    #region Transladacao
    [UseSorting]
    [UseFiltering]
    public async Task<List<Transladacao>> GetTransladacaosAsync([Service] DataContext context) => await context.Transladacao!.ToListAsync();
    #endregion
}
