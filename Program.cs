using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введи рік");
int year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи місяць (Наприклад: 2)");
int mounts = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи день");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"результат: {day}/{mounts}/{year}");
