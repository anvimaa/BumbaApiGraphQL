﻿using BumbaApiGraphQL.Data;
using BumbaApiGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BumbaApiGraphQL.Types;

public class Query
{
    #region User
    [UsePaging]
    [UseSorting]
    [UseFiltering]
    public async Task<List<User>> GetUsersAsync([Service] DataContext context) => await context.User!.ToListAsync();

    public async Task<User?> GetMeAsync([Service] DataContext context, int id) => await context.User!.FindAsync(id);
    #endregion

    #region Provincia
    [UsePaging]
    [UseSorting]
    [UseFiltering]
    public async Task<List<Provincia>> GetProvinciasAsync([Service] DataContext context) => await context.Provincias!.ToListAsync();
    #endregion

    #region Municipio
    [UsePaging]
    [UseSorting]
    [UseFiltering]
    public async Task<List<Municipio>> GetMunicipiosAsync([Service] DataContext context) => await context.Municipios!.ToListAsync();
    #endregion

    #region Utente
    [UsePaging]
    [UseSorting]
    [UseFiltering]
    public async Task<List<Utente>> GetUtentesAsync([Service] DataContext context) => await context.Utentes!.ToListAsync();
    #endregion
}
