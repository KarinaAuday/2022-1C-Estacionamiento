namespace _2024__1C_Estacionamiento.Models
{
    public class Direccion
    {
        public int Id { get; set; }

        public string Calle { get; set; }

        public int Numero { get; set; }

        public string Localidad { get; set; }

        public string Provincia { get; set; }

        public string Pais { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
