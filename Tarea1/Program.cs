using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Área de Triángulo");

        Console.Write("Ingrese la longitud de la base del triángulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double area = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine($"El área del triángulo es: {area}");
    }
}
