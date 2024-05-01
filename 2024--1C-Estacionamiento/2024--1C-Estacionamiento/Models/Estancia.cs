using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace _2024__1C_Estacionamiento.Models
{
    public class Estancia
    {
        public int Id { get; set; }

        public Vehiculo Vehiculo { get; set; }

        public Cliente Cliente { get; set; }

        public decimal Monto { get; private set; }

        [DataType(DataType.DateTime)]
        //[DisplayFormat(ApplyFormatInEditMode  = true, DataFormatString ="{0;yyyy/MM/dd HH:mm")]

        public DateTime Inicio { get; set; }

        [DataType(DataType.DateTime)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0;yyyy/MM/dd HH:mm")]
        public DateTime Fin { get; set; }

        public Pago pago { get; set; }
    }
}
