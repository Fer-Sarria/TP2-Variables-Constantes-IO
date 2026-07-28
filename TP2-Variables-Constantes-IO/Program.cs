using System;
namespace TP2_Variables_Constantes_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1.Ejecutar();
        }
    }
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.Write("Por favor, proporciona tu Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ahora, podrias decirme tu apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("¿Que edad tienes?: ");
            string edad = Console.ReadLine();

            Console.WriteLine("Que bueno que tengas {0} años, {1} {2}!", edad, nombre, apellido);
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
