using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FotoStudio.ValidacionesPersonales
{
    public class OnlyLetters : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string contenido = value.ToString();
                if (Regex.IsMatch(contenido, @"[A-Za-z]", RegexOptions.IgnoreCase))
                    return ValidationResult.Success;
                else
                    return new ValidationResult("*" + validationContext.DisplayName + " solo acepta letras");
            }
            else
                return new ValidationResult("*" + validationContext.DisplayName + " es obligatorio");

        }
    }
}