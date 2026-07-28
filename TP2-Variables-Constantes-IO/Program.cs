// 1.Registrar datos personales: Solicitar al usuario ingresar su nombre, apellido y edad.
// Luego muestra un mensaje como: "Hola Juan Pérez, tienes 25 años."
using System;
namespace TP2_Variables_Constantes_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1.Ejecutar();
            Ejercicio2.Ejecutar();
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


// 2. Calcular el área de un rectángulo: Solicita al usuario ingresar la base y la altura de un
// rectángulo.Muestra los valores ingresados como: "El valor de la base es: 24", "El valor
// de la altura es: 45"

public class Ejercicio2 
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese la base del rectangulo: ");
        string baseRect = Console.ReadLine();

        Console.Write("Ingrese la altura del rectangulo: ");
        string alturaRect = Console.ReadLine();

        Console.WriteLine("El valor de la base es: {0}", baseRect);
        Console.WriteLine("El valor de la altura es: {0}", alturaRect);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}