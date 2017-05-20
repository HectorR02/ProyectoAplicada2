using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FotoStudio.Models
{
    public class Servicios
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Descripcion"), Required(ErrorMessage = "*Este campo es obligatorio*")]
        public string Descripcion { get; set; }

        [Display(Name = "Precio"), Required(ErrorMessage = "*Este campo es obligatorio*")]
        public decimal Precio { get; set; }
    }
}