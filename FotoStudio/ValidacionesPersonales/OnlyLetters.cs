using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FotoStudio.ValidacionesPersonales
{
    public class OnlyLetters : ValidationAttribute
    {
        public OnlyLetters() : base ("El campo {0} no puede contener digitos ni caracteres especiales")
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var chars = value.ToString().ToCharArray();
                foreach (var item in chars)
                {
                    if(Char.IsDigit(item))
                    {
                        var msjError = FormatErrorMessage(validationContext.DisplayName);
                        return new ValidationResult(msjError);
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}