using FotoStudio.DAL;
using FotoStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FotoStudio.BLL
{
    public class ArticulosBLL
    {
        public static bool GuardarProvicional()
        {
            bool resultado = false;
            using (var conexion = new FotoStudioDB())
            {
                try
                {
                    conexion.Articulos.Add(new Articulos() { Descripcion = "CD-ROM", Existencia = 10, Precio = 12 });
                    conexion.Articulos.Add(new Articulos() { Descripcion = "SD-Card 4 GB", Existencia = 10, Precio = 12 });
                    conexion.Articulos.Add(new Articulos() { Descripcion = "SD-Card 8GB", Existencia = 10, Precio = 120 });
                    conexion.Articulos.Add(new Articulos() { Descripcion = "CD-DVD", Existencia = 10, Precio = 12 });

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
    }
}