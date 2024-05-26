using _2024__1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2024__1C_Estacionamiento.ViewModels
{
    //Modelo hecho para registracion de usuario
    public class RegistrarUsuario
    {
        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [EmailAddress(ErrorMessage = ErrorMsge.NoValido)]
        [Display(Name = Alias.Email)]
        //[Remote(action: "EmailDisponible", controller:"Account")]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [DataType(DataType.Password)]
        [Display(Name = Alias.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [DataType(DataType.Password)]
        //Me permite comparar a password
        [Compare("Password", ErrorMessage = ErrorMsge.PassMissmatch)]
        [Display(Name = Alias.PassConfirm)]
        public string ConfirmacionPassword { get; set; }
    }
}
