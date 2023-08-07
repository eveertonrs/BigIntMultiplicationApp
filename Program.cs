using System;
using System.Numerics;

namespace BigIntMultiplicationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            string num1Str = Console.ReadLine();

            Console.WriteLine("Digite o segundo número:");
            string num2Str = Console.ReadLine();

            BigInteger num1 = BigInteger.Parse(num1Str);
            BigInteger num2 = BigInteger.Parse(num2Str);

            BigInteger result = BigInteger.Multiply(num1, num2);

            Console.WriteLine($"Resultado da multiplicação: {result}");
        }
    }
}
