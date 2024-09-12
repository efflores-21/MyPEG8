using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_3.modelo
{
    internal class PERSONA
    {
        public PERSONA() { }

        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }
        public int CalcularEdad()
        {
            int edad = 0;
            try
            {
                edad = DateTime.Now.Year - FechaNac.Year;
            }
            catch (Exception ex)
            {
                Console.WriteLine( $"Ocurrio un error:  { ex.Message}");
            }
            return edad;
        }

        public string EvaluarEdad()
        {

            if (CalcularEdad()<= 18)
            {
                return "Menor de edad";
            }
            else if (CalcularEdad() >= 18 && CalcularEdad() < 60)
            {
                return "Adulto";
            }
            else
            {
                return "Adulto mayor";
            }
        }
    }
}
