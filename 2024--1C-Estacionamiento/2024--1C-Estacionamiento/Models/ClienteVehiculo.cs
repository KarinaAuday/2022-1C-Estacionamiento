namespace _2024__1C_Estacionamiento.Models
{
    public class ClienteVehiculo
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public int VehiculoId { get; set; }

        public Vehiculo Vehiculo { get; set; }

        
    }
}
