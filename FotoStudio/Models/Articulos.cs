using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace FotoStudio.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }

        [StringLength(25, ErrorMessage = "*La longitud del {0} no debe ser menor de {2} caractéres", MinimumLength = 3)]
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [DataType(DataType.Text), Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [RegularExpression(@"^[0-9]*", ErrorMessage = "*Este campo solo acepta numeros"), Display(Name = "Existencia")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [RegularExpression(@"^[0-9]*", ErrorMessage = "*Este campo solo acepta numeros"), Display(Name = "Precio")]
        //[DataType(DataType.Currency)]
        public decimal Precio { get; set; }
    }
}