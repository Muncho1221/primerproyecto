using System;

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Áreas Geométricas");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Calcular el área de un triángulo");
        Console.WriteLine("2. Calcular el área de un cuadrado");
        Console.Write("Opción: ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                CalcularAreaTriangulo();
                break;
            case "2":
                CalcularAreaCuadrado();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    public static void CalcularAreaTriangulo()
    {
        Console.WriteLine("\nCalculadora de Área de Triángulo");

        Console.Write("Ingrese la longitud de la base del triángulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double area = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine($"El área del triángulo es: {area}");
    }

    public static void CalcularAreaCuadrado()
    {
        Console.WriteLine("\nCalculadora de Área de Cuadrado");

        Console.Write("Ingrese la longitud de un lado del cuadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());

        double area = lado * lado;

        Console.WriteLine($"El área del cuadrado es: {area}");
    }
}

