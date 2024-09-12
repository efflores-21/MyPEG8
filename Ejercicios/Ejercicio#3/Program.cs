namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio del circulo: ");

            string entrada = Console.ReadLine();  

            double radio = Convert.ToDouble(entrada);  

            double area = 3.1416 * (radio * radio);

            Console.WriteLine("El area del circulo es: " + area);
        }
    }
}
