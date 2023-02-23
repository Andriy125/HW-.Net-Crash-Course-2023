using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть радіус кола: ");
double r = Convert.ToDouble(Console.ReadLine());
double s = Math.PI * Math.Pow(r, 2);

Console.WriteLine($"Площа кола з радіусом {r} рівна: {Math.Round(s, 2)}");