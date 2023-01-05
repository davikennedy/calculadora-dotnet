using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Subtracao();
        }

        static void Soma() 
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;
            Console.WriteLine($"\nO resultado da soma é {resultado}");
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;
            Console.WriteLine($"\nO resultado da subtração é {resultado}");
            Console.ReadKey();
        }
    }
}