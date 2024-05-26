using _2024__1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2024__1C_Estacionamiento.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [Display(Name = "Correo Electrónico")]
        [EmailAddress(ErrorMessage = ErrorMsge.NoValido)]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [DataType(DataType.Password)]
        [Display(Name = Alias.Password)]
        public string Password { get; set; }


        public bool Recordarme { get; set; } = false;
    }
}
