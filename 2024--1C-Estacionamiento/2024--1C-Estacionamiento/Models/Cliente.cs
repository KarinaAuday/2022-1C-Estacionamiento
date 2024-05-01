using System.ComponentModel.DataAnnotations;

namespace _2024__1C_Estacionamiento.Models
{
    public class Cliente : Persona
    {

        public Cliente() { }

        [Required]
        [Display(Name = "Numero Cuil")]
        public long Cuil { get; set; }

        public Direccion Direccion { get; set; }


        public List<ClienteVehiculo> VehiculosAutorizados { get; set; }

    }
}
