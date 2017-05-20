using FotoStudio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FotoStudio.DAL
{
    public class FotoStudioDB : DbContext
    {
        public FotoStudioDB() : base("StrConn")
        {

        }

        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<TipoUsuarios> UserType { get; set; }
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<VentaItems> Items { get; set; }
    }
}