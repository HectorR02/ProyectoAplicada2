using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FotoStudio.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre Completo"), Required(ErrorMessage = "*Este campo es obligatorio*")]
        [StringLength(100, ErrorMessage = "La longitud del {0} no debe ser menor de {2} caractéres", MinimumLength = 5)]
        public string FullName { get; set; }

        [Display(Name = "Nombre de Usuario"), Required(ErrorMessage = "*Este campo es obligatorio*")]
        [StringLength(12, ErrorMessage = "La longitud del {0} no debe ser menor de {2} caractéres", MinimumLength = 5)]
        public string UserName { get; set; }

        [EmailAddress]
        [Display(Name = "Correo Electrónico"), Required(ErrorMessage = "*Este campo es obligatorio*")]
        public string Email { get; set; }

        [DataType(DataType.Password), Required(ErrorMessage = "*Este campo es obligatorio*")]
        [StringLength(15, ErrorMessage = "La longitud del {0} no debe ser menor de {2} caractéres", MinimumLength = 8)]
        public string Contraseña { get; set; }

        [Display(Name = "Tipo de Usuario"), Required(ErrorMessage = "*Este campo es obligatorio*")]
        public int Tipo { get; set; }
    }
}