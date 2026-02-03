using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Mayor de Tres Números y Par/Impar ---");

        // Solicitar y leer los tres números
        int num1 = GetNumberFromUser("Ingrese el primer número: ");
        int num2 = GetNumberFromUser("Ingrese el segundo número: ");
        int num3 = GetNumberFromUser("Ingrese el tercer número: ");

        // Encontrar el mayor de los tres números
        int mayor = Math.Max(num1, Math.Max(num2, num3));

        Console.WriteLine($"\nEl mayor de los tres números es: {mayor}");

        // Determinar si el mayor número es par o impar
        if (mayor % 2 == 0)
        {
            Console.WriteLine($