using _2024__1C_Estacionamiento.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2024__1C_Estacionamiento.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Creo Persona con Get
        public ActionResult CreateGet()   //Ejemplo Con Get
        {


            return View();

        }
        //Creo Persona con Post
        public ActionResult CreatePost() //Ejemplo con Post
        {


            return View();

        }
        //Creo persona con query string
        public IActionResult CrearPersona(String nombre, String apellido)
        {
            Persona persona = new Persona()

            {
                Apellido = apellido,
                // Dni = dni,
                Nombre = nombre,
            };

            return View(persona);

        }
    }
}
