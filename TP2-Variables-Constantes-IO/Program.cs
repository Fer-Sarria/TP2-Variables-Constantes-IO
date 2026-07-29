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
            //Ejercicio2.Ejecutar();
            //Ejercicio3.Ejecutar();
            //Ejercicio4.Ejecutar();
            //Ejercicio5.Ejecutar();
            //Ejercicio6.Ejecutar();
            Ejercicio7.Ejecutar();
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

// 3. Conversión de temperatura: Pide al usuario ingresar el nombre de una ciudad y su
// temperatura en grados Celsius. Muestra: "En Córdoba, la temperatura es de 20°C."

public class Ejercicio3
{
    public static void Ejecutar()
    {  
        Console.Clear();
        Console.Write("Ingrese el nombre de una ciudad: ");
        string ciudad = Console.ReadLine();

        Console.Write("Ingrese la temperatura en grado Celcius: ");
        string temperatura = Console.ReadLine();

        Console.WriteLine("En {0}, la temperatura es de {1}°C", ciudad, temperatura);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 4. Encuesta de gustos: Solicita al usuario ingresar un color y su comida favorita. Muestra
// por pantalla el mensaje: "Tu color favorito es azul y tu comida favorita es pizza."

public class Ejercicio4
{
    public static void Ejecutar()
    {  
        Console.Clear();
        Console.Write("Ingrese un color: ");
        string color = Console.ReadLine();

        Console.Write("Ingrese su comida favorita: ");
        string comida = Console.ReadLine();

        Console.WriteLine("Tu color favorito es {0} y tu comida favorita es {1}", color, comida);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 5. Datos de un producto: Pide al usuario ingresar el nombre de un producto y su precio.
// Muestra por pantalla el mensaje: "El producto 'Laptop' cuesta $1200."

public class Ejercicio5
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el nombre de un producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese su precio: ");
        string precio = Console.ReadLine();

        Console.WriteLine("El producto {0} cuesta ${1}", producto, precio);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadLine();
    }
}

// 6. Registro escolar: Solicita al usuario el nombre del estudiante, el curso, y su nota final.
// Muestra por pantalla el mensaje: "Estudiante: Carla López - Curso: Matemáticas - Nota: 9.5"

public class Ejercicio6
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el nombre del estudiante: ");
        string estudiante = Console.ReadLine();

        Console.Write("Ingrese el curso: ");
        string curso = Console.ReadLine();

        Console.Write("Ingrese su nota final: ");
        string nota = Console.ReadLine();

        Console.WriteLine("Estudiante: {0} - Curso: {1} - Nota: {2}", estudiante, curso, nota);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadLine();
    }
}

// 7. Información de contacto: Solicita el nombre, correo electrónico y teléfono del usuario.
// Muestra: "Usuario: Luis Ramos - Email: luis@mail.com - Tel: 123456789"

public class Ejercicio7
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su correo electrónico: ");
        string email = Console.ReadLine();

        Console.Write("Ingrese su teléfono : ");
        string telefono = Console.ReadLine();

        Console.WriteLine("Usuario: {0} - Email: {1} - Tel: {2}", nombre, email, telefono);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadLine();
    }
}

// 8. Cálculo de edad: Pide al usuario el año actual y su año de nacimiento. Muestra por
// pantalla: "El año actual es 2025 y tu año de nacimiento es 1982."