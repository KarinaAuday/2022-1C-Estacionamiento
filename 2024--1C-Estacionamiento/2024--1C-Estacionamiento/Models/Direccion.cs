using _2024__1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024__1C_Estacionamiento.Models
{
    public class Direccion
    {
        [Key, ForeignKey("Persona")]

        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        public String Calle { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]


        public int Numero { get; set; }

        public long CodPostal { get; set; }

        public Persona Persona
        {
            get; set;
        }
    }
}
