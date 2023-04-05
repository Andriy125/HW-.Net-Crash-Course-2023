using System;
using System.Collections.Generic;


public class Calculator
{
    private Dictionary<string, Func<double, double, double>> operations;
    private Dictionary<string, Func<double, double>> functions;

    public Calculator()
    {
        operations = new Dictionary<string, Func<double, double, double>>();
        operations.Add("+", (x, y) => x + y);
        operations.Add("-", (x, y) => x - y);
        operations.Add("*", (x, y) => x * y);
        operations.Add("/", (x, y) => x / y);

        functions = new Dictionary<string, Func<double, double>>();
        functions.Add("sin", x => Math.Sin(x));
        functions.Add("cos", x => Math.Cos(x));
        functions.Add("tan", x => Math.Tan(x));
    }

    public double Calculate(string operation, double x, double y)
    {
        if (!operations.ContainsKey(operation))
        {
            throw new ArgumentException("Invalid operation");
        }

        return operations[operation](x, y);
    }

    public double Calculate(string function, double x)
    {
        if (!functions.ContainsKey(function))
        {
            throw new ArgumentException("Invalid function");
        }

        return functions[function](x);
    }

    public double Calculate(string expression)
    {
        string[] parts = expression.Split(' ');
        if (parts.Length == 3)
        {
            double x = double.Parse(parts[0]);
            double y = double.Parse(parts[2]);
            string op = parts[1];

            return Calculate(op, x, y);
        }
        else if (parts.Length == 2)
        {
            double x = double.Parse(parts[1]);
            string func = parts[0];

            return Calculate(func, x);
        }
        else
        {
            throw new ArgumentException("Invalid expression format");
        }

    }
}



