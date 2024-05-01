using _2024__1C_Estacionamiento.Models;

namespace _2024__1C_Estacionamiento.Data
{
    public class RepoPersonas
    {
        private List<Persona> _personas;

        public RepoPersonas()
        {
            _personas = new List<Persona>();
            Persona persona = new Persona() { Nombre = "Luis", Apellido = "Spinetta", Email = "LSpinetta@gmail.com" };
            Persona persona2 = new Persona() { Nombre = "Chaly", Apellido = "Garcia", Email = "Cgarcia@gmail.com" };
            Persona persona3 = new Persona() { Nombre = "Gustavo", Apellido = "Cerati", Email = "Cerati@gmail.com" };
            Persona persona4 = new Persona() { Nombre = "Astor", Apellido = "Piazolla", Email = "¨Piazolla@gmail.com" };
            Persona persona5 = new Persona() { Nombre = "Miguel", Apellido = "Mateos", Email = "¨Mateos@gmail.com" };
            _personas.Add(persona);
            _personas.Add(persona2);
            _personas.Add(persona3);
            _personas.Add(persona4);
            _personas.Add(persona5);
        }

        public List<Persona> Personas
        {

            get { return _personas; }
            set { _personas = value; }

        }
    }   
}
