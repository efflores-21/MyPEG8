using Sesion_3.modelo;
namespace Sesion_3
{
   internal class Program
    {
        static void Main(string[] args)
        {
            PERSONA persona = new PERSONA();
            string nombre;
            DateTime fechaNac;
            Console.WriteLine("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento: ");
            fechaNac = DateTime.Parse(Console.ReadLine());
            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;
            Console.WriteLine(persona.EvaluarEdad());

        }
    }
}