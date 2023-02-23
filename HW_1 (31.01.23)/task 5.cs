using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть рік: ");
int input = Convert.ToInt32(Console.ReadLine());
bool isLeapYear = DateTime.IsLeapYear(input);

if (isLeapYear)
{
    Console.WriteLine("В цьому році 366 днів");
}
else
{
    Console.WriteLine("В цьому році 365 днів");
}
