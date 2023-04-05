using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Доступні операції: +, -, *, /, sin, cos, tan");
        Console.WriteLine("Ось приклад введення: 2 + 3 або sin 1,2. Пробіли мають бути ОБОВ'ЯЗКОВО");

        while (true)
        {
            Console.WriteLine("\nВведіть свій приклад: ");
            string? InputExpression = Console.ReadLine();
            double result = calculator.Calculate(InputExpression);
            Console.Write($"{InputExpression} = {result}");
        }



    }
}

