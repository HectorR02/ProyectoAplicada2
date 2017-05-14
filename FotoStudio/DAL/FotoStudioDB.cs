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

        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<TipoUsuarios> UserType { get; set; }
    }
}