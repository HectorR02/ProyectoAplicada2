using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FotoStudio.DAL;
using FotoStudio.Models;

namespace FotoStudio.BLL
{
    public class UsuariosBLL
    {
        public static bool Existe(string nombreUsuario)
        {
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    return (conexion.Usuario.Where(u => u.UserName.Equals(nombreUsuario)).FirstOrDefault() != null);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static bool Guardar(Usuarios usuario)
        {
            bool resultado = false;
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    if (!Existe(usuario.UserName))
                    {
                        conexion.Usuario.Add(usuario);
                        conexion.SaveChanges();
                        resultado = true;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
    }
}