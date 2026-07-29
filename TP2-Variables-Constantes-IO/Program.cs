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
            //Ejercicio7.Ejecutar();
            //Ejercicio8.Ejecutar();
            //Ejercicio9.Ejecutar();
            //Ejercicio10.Ejecutar();
            //Ejercicio11.Ejecutar();
            //Ejercicio12.Ejecutar();
            //Ejercicio13.Ejecutar();
            //Ejercicio14.Ejecutar();
            //Ejercicio15.Ejecutar();
            //Ejercicio16.Ejecutar();
            Ejercicio17.Ejecutar();
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
        Console.ReadKey();
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
        Console.ReadKey();
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
        Console.ReadKey();
    }
}

// 8. Cálculo de edad: Pide al usuario el año actual y su año de nacimiento. Muestra por
// pantalla: "El año actual es 2025 y tu año de nacimiento es 1982."

public class Ejercicio8
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el año actual: ");
        string anioActual = Console.ReadLine();

        Console.Write("Ingrese su año de nacimiento: ");
        string anioNacimiento = Console.ReadLine();


        Console.WriteLine("El año actual es {0} y tu año de nacimiento es {1}", anioActual, anioNacimiento);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 9. Ingreso de coordenadas: Pide al usuario ingresar las coordenadas X y Y. Muestra por
// pantalla el mensaje: "Las coordenadas ingresadas son (3, 7)."

public class Ejercicio9
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese la coordenada X: ");
        string coordX = Console.ReadLine();

        Console.Write("Ingrese la coordenada Y: ");
        string coordY = Console.ReadLine();


        Console.WriteLine("Las coordenadas ingresadas son ({0}, {1})", coordX, coordY );

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 10. Boletos de cine: Solicita el nombre del cliente, número de boletos y el precio por boleto.
// Muestra: "Carlos compró 3 boletos a $5.50 cada uno."

public class Ejercicio10
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el nombre del cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Ingrese el número de boletos: ");
        string boletos = Console.ReadLine();

        Console.Write("Ingrese el precio por boleto : ");
        string precio = Console.ReadLine();

        Console.WriteLine("{0} compró {1} boletos a ${2} cada uno.", cliente, boletos, precio);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 11. Encuesta de mascotas: Pide al usuario un tipo de mascota, su nombre y edad. Muestra
// el mensaje por pantalla: "Tu mascota es un perro, se llama Max y tiene 4 años."

public class Ejercicio11
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese un tipo de mascota: ");
        string tipo = Console.ReadLine();

        Console.Write("Ingrese el nombre de la mascota: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la edad de la mascota: ");
        string edad = Console.ReadLine();

        Console.WriteLine("Tu mascota es un {0}, se llama {1} y tiene {2} años", tipo, nombre, edad);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 12. Peso y Altura: Solicita el peso en kg y altura en metros. Muestra en pantalla: "Tienes un
// peso de 70kg y una altura de 1.75m"

public class Ejercicio12
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el peso en Kg: ");
        string peso = Console.ReadLine();

        Console.Write("Ingrese la altura en metros: ");
        string altura = Console.ReadLine();


        Console.WriteLine("Tienes un peso de {0}Kg y una altura de {1}mw", peso, altura);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 13. Compra en línea:Pide el nombre del cliente, producto y cantidad. Muestra en pantalla:
// "Lucía compró 2 unidades del producto 'Mouse'."

public class Ejercicio13
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el nombre del cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Ingrese el producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese la cantidad: ");
        string cantidad = Console.ReadLine();

        Console.WriteLine("{0} compró {1} unidades del producto '{2}'", cliente, cantidad, producto);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 14. Datos de viaje: Solicita el destino, la distancia en km y el tiempo estimado en horas.
// Muestra en pantalla: "Viaje a Mendoza - 1000 km - Tiempo estimado: 12 horas."

public class Ejercicio14
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el destino: ");
        string destino = Console.ReadLine();

        Console.Write("Ingrese la distancia en Km: ");
        string distancia = Console.ReadLine();

        Console.Write("Ingrese el tiempo estimado en horas: ");
        string tiempo = Console.ReadLine();

        Console.WriteLine("Viaje a {0} - {1}Km - Tiempo estimado: {2} horas.", destino, distancia, tiempo);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 15. Registro de vehículo: Pide al usuario marca, modelo y año del automóvil. Muestra en
// pantalla: "Vehículo registrado: Toyota Corolla - Año: 2020"

public class Ejercicio15
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese la marca del automóvil: ");
        string marca = Console.ReadLine();

        Console.Write("Ingrese el modelo del automóvil: ");
        string modelo = Console.ReadLine();

        Console.Write("Ingrese el año del automóvil: ");
        string anio = Console.ReadLine();

        Console.WriteLine("Vehículo registrado: {0} {1} - Año {2}", marca, modelo, anio);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 16. Plan de estudios: Pide el nombre del alumno, asignatura y profesor. Muestra en
// pantalla: "María cursa Programación con el profesor Gómez."

public class Ejercicio16
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el nombre del alumno: ");
        string alumno = Console.ReadLine();

        Console.Write("Ingrese la asignatura: ");
        string asignatura = Console.ReadLine();

        Console.Write("Ingrese el nombre del profesor: ");
        string profesor = Console.ReadLine();

        Console.WriteLine("{0} cursa {1} con el profesor {2}", alumno, asignatura,profesor);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

// 17. Horario de clase: Solicita el día, hora de inicio y duración. Muestra en pantalla: "Clase el
// martes a las 10:00 AM, duración: 2 horas."

public class Ejercicio17
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.Write("Ingrese el día: ");
        string dia = Console.ReadLine();

        Console.Write("Ingrese hora de inicio: ");
        string hora = Console.ReadLine();

        Console.Write("Ingrese la duración en horas: ");
        string duracion = Console.ReadLine();

        Console.WriteLine("Clase el {0} a las {1} AM, duración: {2} horas.", dia, hora, duracion);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}