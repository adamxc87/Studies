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

            // 8. Multiplication Table
            Console.WriteLine("ZADANIE 8.");
            int num = 1;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

            // 9. Average of Four Numbers
            Console.WriteLine("ZADANIE 9.");
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int n4 = 4;
            double avg = (n1 + n2 + n3 + n4) / 4.0;
            Console.WriteLine($"The average of {n1}, {n2}, {n3}, {n4} is: {avg}");

            // 10. Specified Formula with Three Numbers
            Console.WriteLine("ZADANIE 10.");
            int x = 5;
            int y = 6;
            int z = 7;
            int result1 = (x + y) * z;
            int result2 = x * y + y * z;
            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {result1} and x * y + y * z is {result2}");
        }
    }
}
