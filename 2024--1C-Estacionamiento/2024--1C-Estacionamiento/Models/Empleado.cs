using _2024__1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2024__1C_Estacionamiento.Models
{
    public class Empleado : Persona
    {
        [Required(ErrorMessage = ErrorMsge.Requerido)]
        [StringLength(Restrictions.FloorL4, MinimumLength = Restrictions.CeilL1, ErrorMessage = ErrorMsge.Longitud)]
        public string CodigoEmpleado { get; set; }

    }
}
