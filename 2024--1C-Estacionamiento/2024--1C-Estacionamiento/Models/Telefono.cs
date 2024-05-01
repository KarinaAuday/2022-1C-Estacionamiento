using _2024__1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2024__1C_Estacionamiento.Models
{
    public class Telefono
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        public int CodArea { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [DataType(DataType.PhoneNumber)]
        public string Numero { get; set; }

        public bool Principal { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        public TipoTelefono Tipo { get; set; }


        [Required(ErrorMessage = ErrorMsge.Requerido)]
        
       

         public int PersonaId { get; set; }

        public Persona Persona { get; set; }

        //public Cliente Cliente { get; set; }

        [NotMapped]
        public string NumeroCompleto { get { return $"({CodArea}) - {Numero}"; } }

    }
}
