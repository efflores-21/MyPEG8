namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su cargo:");
            string cargo = Console.ReadLine();

            Console.WriteLine("Ingrese su salario:");
            double salario = Convert.ToDouble(Console.ReadLine());

            double aumento = salario * 0.10;
            double nuevoSalario = salario + aumento;

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Salario Original: " + salario);
            Console.WriteLine("Aumento: " + aumento);
            Console.WriteLine("Nuevo Salario: " + nuevoSalario);
        }
    }
}
