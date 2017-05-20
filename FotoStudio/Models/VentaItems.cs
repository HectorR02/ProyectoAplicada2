using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FotoStudio.Models
{
    public class VentaItems
    {
        [Key]
        public int ItemId { get; set; }

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [ScaffoldColumn(false)]
        public bool EsServicio { get; set; }

        [Display(Name = "Cantidad")]
        [RegularExpression(@"^[0-9]*", ErrorMessage = "Este campo solo acepta números")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio"), DataType(DataType.Currency)]
        [RegularExpression(@"^[0-9]*", ErrorMessage = "Este campo solo acepta números")]
        public double Precio { get; set; }

        [ScaffoldColumn(false)]
        public int VentaId { get; set; }

        [ScaffoldColumn(false)]
        public int ArtServId { get; set; }
    }
}