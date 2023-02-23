using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Виберіть дію яку бажаєте виконати:\n" +
    "1 - Отримати радіус кола\n" +
    "2 - Отримати площу кола\n" +
    "3 - Отримати периметр кола\n\n" +
    "Ваш вибір: ");
int operation = Convert.ToInt32(Console.ReadLine());

Console.Write("Введіть діаметр окружності: ");
double diameter = Convert.ToDouble(Console.ReadLine());

double DoOperation(int operation, double diameter)
{
    double result = operation switch
    {
        1 => diameter / 2,
        2 => Math.PI * Math.Pow(diameter / 2, 2),
        3 => 2 * Math.PI * (diameter / 2)
    };
    return result;
}

double result = DoOperation(operation, diameter);
result = double.Round(result, 2);

Console.WriteLine(("\n").PadRight(24, '-'));
Console.WriteLine($"Результат: {result}");