using FotoStudio.DAL;
using FotoStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FotoStudio.BLL
{
    public class UserTypeBLL
    {
        public static bool Guardar()
        {
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    conexion.UserType.Add(new Models.TipoUsuarios() { Description = "Administrador" });
                    conexion.UserType.Add(new Models.TipoUsuarios() { Description = "Cajero" });
                    conexion.UserType.Add(new Models.TipoUsuarios() { Description = "Diseñado" });
                    conexion.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }
        public static List<TipoUsuarios> GetTypes()
        {
            List<TipoUsuarios> lista = new List<TipoUsuarios>();
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    lista = conexion.UserType.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static string GetDescripcion(int typeId)
        {
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    return conexion.UserType.Find(typeId).Description;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return "";
        }
    }
}