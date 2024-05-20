using _2024__1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2024__1C_Estacionamiento.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsge.Requerido)]
        public int Patente { get; set; }

        [Required]
        [Display(Name = "Marca Auto")]
        public string Marca { get; set; }

        
        [Required(ErrorMessage = ErrorMsge.Requerido)]
        public string Color { get; set; }


        [Range(Restrictions.FloorVehiculoAnio, Restrictions.CeilVehiculoAnio, ErrorMessage = ErrorMsge.Longitud)]
        [Display(Name = Alias.Anio)]
        public int AnioFabricacion { get; set; } = DateTime.Now.Year;

        public List<ClienteVehiculo> PersonasAutorizadas { get; set; }



        public Vehiculo(int patente, string marca, string color)
        {
            this.Patente = patente;
            this.Marca = marca;
            this.Color = color;
                
        }
                    
    }
}
