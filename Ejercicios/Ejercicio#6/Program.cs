namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            int mayor;

            if (numero1 >= numero2 && numero1 >= numero3)
            {
                mayor = numero1;
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }

            Console.WriteLine("El numero mayor es: " + mayor);
        }
    }
}
