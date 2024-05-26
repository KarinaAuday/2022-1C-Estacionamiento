using _2024__1C_Estacionamiento.Data;
using _2024__1C_Estacionamiento.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2024__1C_Estacionamiento.Controllers
{
    public class IniBaseDatos : Controller
    {
        private readonly EstacionamientoContext _context;

        public IniBaseDatos(EstacionamientoContext context)
        {
            _context = context;
        }


        private List<Persona> personas = new List<Persona>()
        {
             new Persona() { Nombre = "Luis", Apellido = "Spinetta", Dni = "22334455", Email = "LSpinetta@gmail.com" },
             new Persona() { Nombre = "Chaly", Apellido = "Garcia", Dni = "22374455", Email = "Cgarcia@gmail.com" },
             new Persona() { Nombre = "Gustavo", Apellido = "Cerati", Dni = "12374455", Email = "Cerati@gmail.com" },
             new Persona() { Nombre = "Astor", Apellido = "Piazolla", Dni = "22884455", Email = "¨Piazolla@gmail.com" },
             new Persona() { Nombre = "Miguel", Apellido = "Mateos", Dni = "26374455", Email = "¨Mateos@gmail.com" }
         };

        private IActionResult CrearPersonas()
        {
            foreach (var persona in personas)
            {
                //Valido que no tenga el DNI cargado
                if (!_context.Personas.Any(e => e.Dni == persona.Dni))
                {
                    _context.Personas.Add(persona);
                    _context.SaveChanges();
                }

            }
            return Content("Personas Cargadas");
        }
    }
}
