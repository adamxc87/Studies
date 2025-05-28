using System;

namespace Informatyka_Zajecia_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Print Hello and Name
            Console.WriteLine("ZADANIE 1.");
            Console.WriteLine("Hello");
            Console.WriteLine("Adam");
            Console.WriteLine();

            // 2. Sum of Two Numbers
            Console.WriteLine("ZADANIE 2.");
            int sum = 5 + 7;
            Console.WriteLine($"SUM: {sum}");
            Console.WriteLine();

            // 3. Divide Two Numbers
            Console.WriteLine("ZADANIE 3.");
            int result = 12 / 2;
            Console.WriteLine($"SUM: {result}");
            Console.WriteLine();

            // 4. Divide Two Numbers
            Console.WriteLine("ZADANIE 4.");
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine();

            // 5. Swap Two Numbers
            Console.WriteLine("ZADANIE 5.");
            int a = 3;
            int b = 5;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + a);
            Console.WriteLine("Second Number: " + b);

            // 6. Multiply Three Numbers;
            Console.WriteLine("ZADANIE 6.");
            int num1 = 2;
            int num2 = 4;
            int num3 = 10;
            int resultOfMultiply = num1 * num2 * num3;
            Console.WriteLine($"{num1} x {num2} x {num3} = {resultOfMultiply}");

            // 7. Arithmetic Operations
            Console.WriteLine("ZADANIE 7.");
            int c = 2;
            int d = 5;
            Console.WriteLine($"{c} + {d} = {c + d}");
            Console.WriteLine($"{c} - {d} = {c - d}");
            Console.WriteLine($"{c} x {d} = {c * d}");
            Console.WriteLine($"{c} / {d} = {c / d}");
            Console.WriteLine($"{c} modulo {d} = {c % d}");
        }
    }
}
