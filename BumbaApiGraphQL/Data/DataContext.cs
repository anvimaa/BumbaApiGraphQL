﻿using BumbaApiGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BumbaApiGraphQL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User>? User { get; set; }
        public DbSet<Provincia>? Provincias { get; set; }
        public DbSet<Municipio>? Municipios { get; set; }
        public DbSet<Utente>? Utentes { get; set; }
        public DbSet<Proprietario>? Proprietarios { get; set; }
    }
}
