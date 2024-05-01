using _2024__1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2024__1C_Estacionamiento.Models
{
    public class Pago
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        public int EstanciaId { get; set; }
        public decimal Monto { get; set; }

        public Estancia Estancia { get; set; }
    }
}