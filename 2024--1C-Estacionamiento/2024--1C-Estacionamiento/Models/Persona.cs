using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using _2024__1C_Estacionamiento.Helpers;



namespace _2024__1C_Estacionamiento.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage =ErrorMsge.Requerido)]
        [StringLength(100, MinimumLength=2, ErrorMessage = ErrorMsge.Longitud)]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Solo se permiten letras")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La cantidad de Caracteres es invalida")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Solo se permiten letras")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Solo se permiten numeros")]
        [Display(Name = Alias.DNI)]

        public string Dni { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = Alias.Email)]
        public string Email { get; set; }

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre}, {Apellido}";
            }
           
        }

        public Direccion Direccion { get; set; }

        public List<Telefono> Telefonos { get; set; }

    }
}
