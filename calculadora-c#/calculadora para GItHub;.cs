using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora simple en C#");

        Console.Write("Introduce el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Selecciona la operación:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        int opcion = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"El resultado de la división es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: División por cero no permitida.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }
}
