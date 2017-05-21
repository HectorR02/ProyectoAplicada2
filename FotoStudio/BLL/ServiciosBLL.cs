using FotoStudio.DAL;
using FotoStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FotoStudio.BLL
{
    public class ServiciosBLL
    {
        public static bool GuardarProvicional()
        {
            bool resultado = false;
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    conexion.Servicios.Add(new Servicios() { Descripcion = "CD-ROM", Precio = 12 });
                    conexion.Servicios.Add(new Servicios() { Descripcion = "SD-Card 4 GB", Precio = 12 });
                    conexion.Servicios.Add(new Servicios() { Descripcion = "SD-Card 8 GB", Precio = 12 });
                    conexion.Servicios.Add(new Servicios() { Descripcion = "CD-DVD", Precio = 12 });

                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static List<Articulos> Listar()
        {
            List<Articulos> listado = new List<Articulos>();
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    listado = conexion.Articulos.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }
        public static List<SelectListItem> Listado()
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    foreach (var item in conexion.Servicios.ToList())
                    {
                        lista.Add(new SelectListItem() { Text = item.Descripcion, Value = item.Id.ToString() });
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
    }
}