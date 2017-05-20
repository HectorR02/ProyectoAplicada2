using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FotoStudio.Models
{
    [Bind(Exclude = "VentaId")]
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }
        
        [Display(Name = "Tiempo en Horas")]
        [RegularExpression(@"^[0-9]*$")]
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public int TiempoEntrega { get; set; }
        
        public int CantidadItems { get; set; }

        [DataType(DataType.Currency)]
        [RegularExpression(@"^[0-9]*$")]
        public double MontoTotal { get; set; }

        public int ClienteId { get; set; }

        //public int UsuarioId { get; set; }
    }
}