namespace Ejercicio#2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;

            Console.WriteLine("La suma es " + suma);
        }
    }
}
